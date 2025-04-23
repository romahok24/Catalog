CREATE OR REPLACE FUNCTION build_analysis_tree(p_evaluation_path_id INTEGER, p_start_date DATE, p_end_date DATE)
RETURNS TABLE (
    level INT,
    identifier TEXT,
    object_type TEXT,
    name TEXT,
    parent_identifier TEXT,
    path TEXT,
    start_date DATE,
    end_date DATE,
    action TEXT
)
LANGUAGE plpgsql AS
$$
BEGIN
    RETURN QUERY
    WITH steps AS (
        SELECT *
        FROM evaluation_steps
        WHERE evaluation_path_id = p_evaluation_path_id
    ),
    rel_types AS (
        SELECT id, reversed_id FROM relation_types
    ),
    entry_points AS (
        SELECT e.identifier, e.object_type, m.name, m.start_date, m.end_date
        FROM evaluation_entry_points e
        JOIN object_lifetimes l ON l.identifier = e.identifier AND l.object_type = e.object_type
        JOIN LATERAL (
            SELECT mo.name, mo.start_date, mo.end_date
            FROM main_object mo
            WHERE mo.identifier = e.identifier AND mo.object_type = e.object_type
              AND mo.start_date <= p_end_date AND mo.end_date >= p_start_date
            ORDER BY mo.start_date DESC
            LIMIT 1
        ) m ON TRUE
    ),
    RECURSIVE tree AS (
        -- начальные узлы
        SELECT
            1 AS level,
            ep.identifier,
            ep.object_type,
            ep.name,
            NULL::TEXT AS parent_identifier,
            ep.name AS path,
            ep.start_date,
            ep.end_date,
            'joined'::TEXT AS action
        FROM entry_points ep

        UNION ALL

        -- рекурсивное добавление узлов
        SELECT
            t.level + 1,
            mo.identifier,
            mo.object_type,
            mo.name,
            t.identifier AS parent_identifier,
            t.path || ' → ' || mo.name,
            mo.start_date,
            mo.end_date,
            'joined'
        FROM tree t
        JOIN steps s ON s.object_type = t.object_type
        JOIN relations r ON r.parent_identifier = t.identifier AND r.relation_type_id = s.relation_type_id
                         AND r.start_date <= p_end_date AND r.end_date >= p_start_date
        JOIN object_lifetimes l ON l.identifier = r.identifier AND l.object_type = s.related_object_type
        JOIN LATERAL (
            SELECT mo.identifier, mo.object_type, mo.name, mo.start_date, mo.end_date
            FROM main_object mo
            WHERE mo.identifier = r.identifier AND mo.object_type = s.related_object_type
              AND mo.start_date <= p_end_date AND mo.end_date >= p_start_date
            ORDER BY mo.start_date DESC
            LIMIT 1
        ) mo ON TRUE

        UNION ALL

        -- ушедшие
        SELECT
            t.level + 1,
            mo.identifier,
            mo.object_type,
            mo.name,
            t.identifier AS parent_identifier,
            t.path || ' → ' || mo.name || ' [ушел]',
            mo.start_date,
            mo.end_date,
            'left'
        FROM tree t
        JOIN steps s ON s.object_type = t.object_type
        JOIN relations r ON r.parent_identifier = t.identifier AND r.relation_type_id = s.relation_type_id
                         AND r.end_date < p_start_date
        JOIN object_lifetimes l ON l.identifier = r.identifier AND l.object_type = s.related_object_type
        JOIN LATERAL (
            SELECT mo.identifier, mo.object_type, mo.name, mo.start_date, mo.end_date
            FROM main_object mo
            WHERE mo.identifier = r.identifier AND mo.object_type = s.related_object_type
              AND mo.end_date < p_start_date
            ORDER BY mo.start_date DESC
            LIMIT 1
        ) mo ON TRUE
    )
    SELECT DISTINCT level, identifier, object_type, name, parent_identifier, path, start_date, end_date, action
    FROM tree;
END;
$$;
