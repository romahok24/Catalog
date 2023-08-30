using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductCatalog.Data.Migrations
{
    public partial class AddAdminPart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBlocked",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 22.0, "Рыбное", "Острое", "Молоко", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 5.0, "Ароматное", "Шоколадное", "Овощи", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 240.0, "Вареное", "Тушеное", "Орехи", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 147.0, "Свежее", "Свежее", "Курица", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 91.0, "Красивое", "Мягкое", "Сыр", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 220.0, "Молочное", "Ванильное", "Яйца", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 201.0, "Ржаное", "Твердое", "Сахар", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 147.0, "Соленое", "Ванильное", "Кола", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 81.0, "Полезное", "Ржаное", "Мед", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 15.0, "Тушеное", "Вкусное", "Пирог", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 31.0, "Запеченное", "Вареное", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 81.0, "Рыбное", "Твердое", "Молоко", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 103.0, "Свежевыжатое", "Соленое", "Хлеб", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 202.0, "Мясное", "Вареное", "Соус", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 227.0, "Сырое", "Соленое", "Кофе", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 151.0, "Свежевыжатое", "Приправленное", "Кетчуп", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 118.0, "Сочное", "Торт", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 83.0, "Сочное", "Твердое", "Перец", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 239.0, "Красивое", "Нежное", "Салат", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 170.0, "Приправленное", "Сладкое", "Кола", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 191.0, "Рыбное", "Вареное", "Пельмени", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 175.0, "Сочное", "Приправленное", "Чай", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 57.0, "Пряное", "Питательное", "Вода", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 225.0, "Шоколадное", "Яйца", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 248.0, "Острое", "Натуральное", "Торт", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 177.0, "Острое", "Медовое", "Кола", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 190.0, "Сладкое", "Постное", "Молоко", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 117.0, "Шоколадное", "Мясное", "Кетчуп", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 53.0, "Красивое", "Полезное", "Сыр", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 233.0, "Пшеничное", "Тушеное", "Каша", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 26.0, "Сладкое", "Питательное", "Сыр", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 138.0, "Ржаное", "Соленое", "Гречка", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 227.0, "Сырое", "Медовое", "Яйца", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 162.0, "Морское", "Запеченное", "Маргарин", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 241.0, "Жидкое", "Натуральное", "Квас", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 57.0, "Вкусное", "Острое", "Мороженное", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 108.0, "Сырое", "Приправленное", "Кола", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 228.0, "Свежевыжатое", "Тушеное", "Торт", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 5, 39.0, "Фруктовое", "Шоколадное", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 27.0, "Пикантное", "Фруктовое", "Картофель", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 55.0, "Овощное", "Шоколадное", "Овощи", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 52.0, "Медовое", "Овощное", "Торт", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 59.0, "Жидкое", "Соленое", "Сгущенка", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 57.0, "Пряное", "Сытное", "Соус", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 27.0, "Запеченное", "Пряное", "Каша", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 183.0, "Мясное", "Жареное", "Маргарин", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 87.0, "Твердое", "Тушеное", "Рис", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 73.0, "Пряное", "Постное", "Пирог", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 131.0, "Сладкое", "Натуральное", "Квас", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 24.0, "Сырое", "Постное", "Сок", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 243.0, "Сырое", "Пшеничное", "Рис", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 53.0, "Пряное", "Ароматное", "Овощи", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 206.0, "Рыбное", "Овощное", "Перец", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 236.0, "Ванильное", "Шоколадное", "Кола", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 179.0, "Ароматное", "Ароматное", "Перец", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 183.0, "Шоколадное", "Запеченное", "Красное вино", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 238.0, "Полезное", "Сладкое", "Маргарин", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 245.0, "Морское", "Тушеное", "Вода", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 12, 248.0, "Мягкое", "Морковь", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 185.0, "Сладкое", "Твердое", "Кетчуп", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 219.0, "Сытное", "Соленое", "Красное вино", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 126.0, "Овощное", "Сытное", "Огурцы", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 89.0, "Красивое", "Медовое", "Яйца", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 229.0, "Соленое", "Сочное", "Сок", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 85.0, "Ржаное", "Шоколадное", "Маргарин", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 67.0, "Вареное", "Ржаное", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 15.0, "Ароматное", "Запеченное", "Шоколад", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 175.0, "Фруктовое", "Приправленное", "Кетчуп", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 221.0, "Твердое", "Мясное", "Шоколад", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 43.0, "Пикантное", "Свежевыжатое", "Кекс", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 77.0, "Шоколадное", "Острое", "Молоко", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 244.0, "Пикантное", "Натуральное", "Вода", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 61.0, "Постное", "Полезное", "Красное вино", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 247.0, "Морское", "Тушеное", "Морепродукты", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 79.0, "Питательное", "Твердое", "Чай", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 201.0, "Запеченное", "Сытное", "Квас", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 17.0, "Жидкое", "Пикантное", "Курица", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 20.0, "Морское", "Мягкое", "Томаты", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 225.0, "Свежее", "Натуральное", "Яйца", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 243.0, "Пшеничное", "Шоколадное", "Гречка", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 4, 99.0, "Нежное", "Сладкое", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 156.0, "Питательное", "Молочное", "Яйца", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 41.0, "Мягкое", "Мясное", "Кола", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 6, 146.0, "Жидкое", "Вкусное", "Огурцы" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 167.0, "Пшеничное", "Твердое", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 166.0, "Постное", "Твердое", "Кола", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 248.0, "Овощное", "Пикантное", "Морепродукты", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 144.0, "Вареное", "Пшеничное", "Маргарин", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 38.0, "Приправленное", "Острое", "Соль", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 18, 22.0, "Мясное", "Мороженное", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 131.0, "Пряное", "Ванильное", "Яйца", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 11, 212.0, "Сладкое", "Сладкое", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 79.0, "Сладкое", "Жидкое", "Сгущенка", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 135.0, "Нежное", "Жидкое", "Перец", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 2.0, "Мягкое", "Сладкое", "Шоколад", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 80.0, "Сырое", "Медовое", "Тушенка", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 21.0, "Жидкое", "Сладкое", "Морепродукты", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 40.0, "Свежее", "Медовое", "Каша", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 191.0, "Сладкое", "Красивое", "Мясо", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 6.0, "Медовое", "Приправленное", "Чай", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 211.0, "Жидкое", "Сладкое", "Мороженное", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 162.0, "Вареное", "Рыбное", "Квас", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "SpecialNote" },
                values: new object[] { 10, 6.0, "Острое", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 98.0, "Ржаное", "Вареное", "Торт", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 35.0, "Сочное", "Натуральное", "Печенье", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 9.0, "Красивое", "Жидкое", "Гречка", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 158.0, "Рыбное", "Полезное", "Перец", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 62.0, "Фруктовое", "Нежное", "Рис", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 100.0, "Пряное", "Шоколадное", "Белое вино", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 105.0, "Вкусное", "Ржаное", "Перец", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 18.0, "Красивое", "Овощное", "Тушенка", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 143.0, "Вкусное", "Тушеное", "Перец", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 115.0, "Красивое", "Сырое", "Яйца", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 64.0, "Мягкое", "Гречка", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 170.0, "Жидкое", "Сытное", "Яйца", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 118.0, "Вареное", "Соленое", "Пирог", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 44.0, "Вареное", "Шоколадное", "Каша", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 131.0, "Шоколадное", "Постное", "Вода", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 56.0, "Овощное", "Мясное", "Кекс", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 121.0, "Сладкое", "Натуральное", "Мед", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 52.0, "Пшеничное", "Приправленное", "Овощи", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 119.0, "Мягкое", "Жидкое", "Шоколад", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 14, 205.0, "Вареное", "Яйца", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 121.0, "Соленое", "Красивое", "Мед", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 156.0, "Сладкое", "Шоколадное", "Яйца", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 137.0, "Ржаное", "Острое", "Сыр", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 244.0, "Ржаное", "Пикантное", "Пирог", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 68.0, "Пикантное", "Сочное", "Пицца", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 136.0, "Питательное", "Питательное", "Кекс", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 114.0, "Рыбное", "Пряное", "Майонез", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 46.0, "Пшеничное", "Острое", "Орехи", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 221.0, "Ароматное", "Полезное", "Красное вино", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 130.0, "Нежное", "Острое", "Морепродукты", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 241.0, "Ванильное", "Сытное", "Маргарин", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 77.0, "Свежее", "Сытное", "Сок", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 38.0, "Медовое", "Свежевыжатое", "Мед", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 97.0, "Свежевыжатое", "Ароматное", "Сок", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 201.0, "Запеченное", "Острое", "Мясо", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 77.0, "Пикантное", "Сочное", "Тушенка", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 229.0, "Постное", "Ржаное", "Курица", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 35.0, "Медовое", "Запеченное", "Шоколад", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 65.0, "Соленое", "Полезное", "Сок", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 166.0, "Сытное", "Вкусное", "Мороженное", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 247.0, "Мясное", "Соленое", "Молоко", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 38.0, "Сочное", "Соленое", "Пирог", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 238.0, "Мясное", "Вкусное", "Шоколад", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 11, 91.0, "Вкусное", "Сок", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 158.0, "Нежное", "Свежее", "Сгущенка", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 134.0, "Приправленное", "Жареное", "Соус", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 113.0, "Ржаное", "Медовое", "Майонез", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 137.0, "Пшеничное", "Вкусное", "Чай", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 86.0, "Питательное", "Пряное", "Красное вино", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 167.0, "Нежное", "Пикантное", "Паста", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 17.0, "Соленое", "Шоколадное", "Тушенка", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 246.0, "Мягкое", "Ароматное", "Мороженное", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 185.0, "Мясное", "Мясное", "Орехи", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 22.0, "Рыбное", "Запеченное", "Паста", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 181.0, "Вареное", "Натуральное", "Морепродукты", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 190.0, "Нежное", "Запеченное", "Сгущенка", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 13, 75.0, "Нежное", "Нежное", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 207.0, "Вареное", "Полезное", "Паста", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 24.0, "Сытное", "Овощное", "Кетчуп", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 88.0, "Мясное", "Питательное", "Соль", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 186.0, "Свежевыжатое", "Питательное", "Печенье", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 18.0, "Медовое", "Твердое", "Кекс", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 213.0, "Острое", "Нежное", "Томаты", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 38.0, "Натуральное", "Сытное", "Сыр", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 238.0, "Вареное", "Острое", "Морковь", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 134.0, "Молочное", "Свежевыжатое", "Мороженное", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 168.0, "Рыбное", "Сладкое", "Белое вино", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 167.0, "Фруктовое", "Твердое", "Сахар", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 175.0, "Сырое", "Тушеное", "Гречка", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 73.0, "Ржаное", "Жидкое", "Овощи", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 78.0, "Свежее", "Фруктовое", "Фрукты", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 146.0, "Мясное", "Жареное", "Фрукты", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 114.0, "Запеченное", "Постное", "Фрукты", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8.0, "Пшеничное", "Вкусное", "Кетчуп", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 143.0, "Нежное", "Твердое", "Сок", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 27.0, "Полезное", "Постное", "Красное вино", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 195.0, "Острое", "Кекс", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 17, 92.0, "Жареное", "Шоколад", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 95.0, "Твердое", "Свежевыжатое", "Майонез", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 79.0, "Свежее", "Свежевыжатое", "Кетчуп", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 128.0, "Тушеное", "Вкусное", "Салат", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 205.0, "Ванильное", "Морское", "Мед", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 63.0, "Рыбное", "Мясное", "Мясо", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 14, 179.0, "Твердое", "Майонез", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 245.0, "Острое", "Сырое", "Курица", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 159.0, "Постное", "Жидкое", "Перец", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 175.0, "Молочное", "Полезное", "Маргарин", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 227.0, "Острое", "Натуральное", "Вода", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 111.0, "Пряное", "Запеченное", "Вода", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 5, 121.0, "Тушеное", "Натуральное", "Квас" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 17.0, "Приправленное", "Шоколадное", "Огурцы", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 11.0, "Вкусное", "Свежее", "Красное вино", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 174.0, "Питательное", "Питательное", "Чай", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 57.0, "Ванильное", "Постное", "Гречка", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 52.0, "Свежевыжатое", "Пряное", "Мясо", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 48.0, "Рыбное", "Натуральное", "Тушенка", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 45.0, "Рыбное", "Полезное", "Овощи", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 125.0, "Рыбное", "Сытное", "Картофель", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 158.0, "Свежее", "Вкусное", "Мясо", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 2, 70.0, "Фруктовое", "Перец", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 146.0, "Сочное", "Мягкое", "Паста", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 152.0, "Соленое", "Сладкое", "Салат", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 82.0, "Сочное", "Пикантное", "Сыр", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7.0, "Пикантное", "Шоколадное", "Шоколад", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 3.0, "Ванильное", "Свежее", "Каша", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 12.0, "Свежевыжатое", "Постное", "Кофе", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 96.0, "Овощное", "Вкусное", "Кетчуп", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 10, 63.0, "Медовое", "Пшеничное", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 78.0, "Пшеничное", "Соленое", "Печенье", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 3, 76.0, "Сытное", "Ароматное", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 157.0, "Рыбное", "Соленое", "Сок", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 139.0, "Сладкое", "Вкусное", "Гречка", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 73.0, "Мясное", "Мягкое", "Белое вино", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 70.0, "Жидкое", "Сладкое", "Пирог", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 129.0, "Мясное", "Морское", "Фрукты", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 34.0, "Красивое", "Красивое", "Майонез", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 75.0, "Свежее", "Мягкое", "Сгущенка", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 19.0, "Медовое", "Жидкое", "Овощи", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 216.0, "Постное", "Мясное", "Шоколад", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 231.0, "Мягкое", "Постное", "Соус", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 71.0, "Постное", "Морское", "Соус", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 46.0, "Фруктовое", "Шоколадное", "Овощи", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 18.0, "Свежее", "Медовое", "Огурцы", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 53.0, "Сытное", "Молочное", "Торт", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 4.0, "Постное", "Ржаное", "Паста", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 212.0, "Ржаное", "Ароматное", "Сок", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 18.0, "Медовое", "Острое", "Орехи", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 16, 245.0, "Свежевыжатое", "Молоко", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 210.0, "Запеченное", "Сырое", "Майонез", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 98.0, "Сладкое", "Питательное", "Красное вино", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 190.0, "Мясное", "Молочное", "Мед", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 11, 196.0, "Тушеное", "Полезное", "Хлеб" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 192.0, "Сладкое", "Жидкое", "Белое вино", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 214.0, "Соленое", "Постное", "Маргарин", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 97.0, "Запеченное", "Овощное", "Морепродукты", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 184.0, "Жидкое", "Сочное", "Пирог", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 32.0, "Свежевыжатое", "Кетчуп", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 21.0, "Приправленное", "Свежевыжатое", "Салат", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 136.0, "Ванильное", "Полезное", "Хлеб", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 188.0, "Острое", "Тушеное", "Макароны", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 195.0, "Питательное", "Постное", "Кофе", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 14.0, "Соленое", "Ванильное", "Рыба", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 225.0, "Фруктовое", "Ароматное", "Маргарин", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 215.0, "Соленое", "Жареное", "Пельмени", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 184.0, "Мягкое", "Красивое", "Картофель", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 61.0, "Морское", "Острое", "Гречка", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 196.0, "Пшеничное", "Овощное", "Соль", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 18, 236.0, "Жидкое", "Пшеничное", "Хлеб" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 11.0, "Ржаное", "Постное", "Мороженное", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 138.0, "Соленое", "Пикантное", "Пицца", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 170.0, "Медовое", "Шоколадное", "Перец", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 61.0, "Вареное", "Нежное", "Паста", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 188.0, "Соленое", "Ржаное", "Соль", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 211.0, "Красивое", "Пряное", "Белое вино", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 239.0, "Пшеничное", "Мясное", "Курица", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 99.0, "Твердое", "Картофель", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 221.0, "Сладкое", "Питательное", "Сок", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 99.0, "Свежевыжатое", "Сладкое", "Перец", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 230.0, "Ванильное", "Шоколадное", "Кола", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 215.0, "Нежное", "Морское", "Маргарин", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 98.0, "Сырое", "Запеченное", "Кекс", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 109.0, "Сладкое", "Жидкое", "Томаты", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 166.0, "Шоколадное", "Ржаное", "Перец", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 162.0, "Острое", "Свежее", "Мороженное", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 173.0, "Ванильное", "Медовое", "Паста", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 65.0, "Сладкое", "Постное", "Огурцы", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 58.0, "Нежное", "Овощное", "Овощи", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 84.0, "Сытное", "Натуральное", "Тушенка", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 23.0, "Пикантное", "Морское", "Каша", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 196.0, "Сладкое", "Питательное", "Вода", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 142.0, "Натуральное", "Медовое", "Пельмени", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 6, 70.0, "Свежее", "Хлеб", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 199.0, "Жареное", "Свежее", "Пельмени", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 197.0, "Овощное", "Питательное", "Морепродукты", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 158.0, "Сырое", "Сочное", "Фрукты", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 34.0, "Фруктовое", "Соус", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 185.0, "Острое", "Нежное", "Салат", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 139.0, "Шоколадное", "Свежевыжатое", "Молоко", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 204.0, "Пшеничное", "Полезное", "Морковь", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 86.0, "Полезное", "Острое", "Торт", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 102.0, "Ванильное", "Приправленное", "Курица", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 40.0, "Фруктовое", "Фруктовое", "Кекс", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 220.0, "Морское", "Твердое", "Фрукты", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 37.0, "Вкусное", "Острое", "Овощи", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 224.0, "Медовое", "Нежное", "Шоколад", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 170.0, "Фруктовое", "Сытное", "Кетчуп", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 142.0, "Пикантное", "Вкусное", "Соус", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 2.0, "Запеченное", "Острое", "Мед", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 169.0, "Сладкое", "Красивое", "Яйца", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 201.0, "Пшеничное", "Красивое", "Паста", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 11, 215.0, "Пшеничное", "Торт", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 224.0, "Жидкое", "Свежевыжатое", "Томаты", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 217.0, "Молочное", "Медовое", "Вода", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 4.0, "Медовое", "Медовое", "Кетчуп", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 6, 8.0, "Натуральное", "Перец", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 23.0, "Тушеное", "Шоколадное", "Кетчуп", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 245.0, "Острое", "Сытное", "Сыр", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 173.0, "Запеченное", "Вкусное", "Кофе", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 50.0, "Пикантное", "Молочное", "Кекс", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 234.0, "Овощное", "Приправленное", "Орехи", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 151.0, "Свежее", "Сырое", "Салат", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 241.0, "Вкусное", "Ванильное", "Шоколад", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 4.0, "Красивое", "Медовое", "Морепродукты", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 218.0, "Сладкое", "Нежное", "Соль", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 203.0, "Натуральное", "Фруктовое", "Печенье", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 248.0, "Молочное", "Красивое", "Кекс", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 143.0, "Ванильное", "Полезное", "Яйца", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 117.0, "Пшеничное", "Красивое", "Салат", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 18, 215.0, "Свежее", "Овощное", "Торт" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 239.0, "Сытное", "Питательное", "Белое вино", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 146.0, "Сладкое", "Острое", "Морковь", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 1.0, "Красивое", "Сыр", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 21.0, "Сладкое", "Приправленное", "Кола", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 98.0, "Жидкое", "Фруктовое", "Рыба", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 2, 142.0, "Мясное", "Жареное", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 84.0, "Красивое", "Медовое", "Мед", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 150.0, "Вареное", "Жидкое", "Сок", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 23.0, "Соленое", "Свежее", "Огурцы", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 153.0, "Сырое", "Жидкое", "Морковь", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 16.0, "Пряное", "Фруктовое", "Тушенка", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 176.0, "Свежевыжатое", "Жидкое", "Картофель", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 7, 77.0, "Ванильное", "Мясное", "Квас" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 11.0, "Молочное", "Соленое", "Томаты", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 188.0, "Твердое", "Медовое", "Торт", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 145.0, "Полезное", "Морское", "Пельмени", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 42.0, "Пряное", "Рыбное", "Квас", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 248.0, "Приправленное", "Молочное", "Вода", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 10.0, "Сырое", "Шоколадное", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 166.0, "Медовое", "Мягкое", "Соль", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 241.0, "Пряное", "Соленое", "Рыба", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 179.0, "Морское", "Мягкое", "Сгущенка", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 66.0, "Запеченное", "Приправленное", "Картофель", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 128.0, "Ванильное", "Твердое", "Томаты", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 121.0, "Запеченное", "Питательное", "Пицца", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 100.0, "Рыбное", "Пикантное", "Белое вино", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 71.0, "Полезное", "Ржаное", "Фрукты", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 189.0, "Натуральное", "Ароматное", "Печенье", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 194.0, "Красивое", "Острое", "Салат", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 196.0, "Фруктовое", "Ржаное", "Яйца", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 179.0, "Пшеничное", "Полезное", "Фрукты", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 50.0, "Острое", "Приправленное", "Кола", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 9, 41.0, "Мясное", "Молоко", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 234.0, "Питательное", "Натуральное", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 29.0, "Острое", "Мягкое", "Пирог", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 150.0, "Сочное", "Приправленное", "Пирог", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 12.0, "Сытное", "Нежное", "Чай", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 7.0, "Медовое", "Ароматное", "Соль", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 108.0, "Сырое", "Пшеничное", "Тушенка", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 10.0, "Молочное", "Шоколадное", "Чай", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 90.0, "Свежевыжатое", "Питательное", "Хлеб", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 96.0, "Свежевыжатое", "Свежее", "Картофель", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 245.0, "Жидкое", "Сочное", "Шоколад", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 22.0, "Мясное", "Острое", "Мороженное", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 23.0, "Жидкое", "Жареное", "Рыба", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 209.0, "Полезное", "Твердое", "Сок", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 114.0, "Постное", "Полезное", "Орехи", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 204.0, "Морское", "Пшеничное", "Курица", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 8, 222.0, "Мясное", "Молочное", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 23.0, "Ванильное", "Сытное", "Молоко", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 231.0, "Сладкое", "Мягкое", "Сок", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 42.0, "Пикантное", "Свежевыжатое", "Сок", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 8, 151.0, "Ароматное", "Полезное", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 58.0, "Красивое", "Свежее", "Соль", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 164.0, "Нежное", "Пикантное", "Паста", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 160.0, "Молочное", "Пикантное", "Чай", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 186.0, "Полезное", "Тушеное", "Чай", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 198.0, "Ванильное", "Ванильное", "Огурцы", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 233.0, "Свежее", "Твердое", "Вода", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 107.0, "Красивое", "Вареное", "Красное вино", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 226.0, "Пряное", "Мясное", "Майонез", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 9.0, "Мясное", "Ржаное", "Орехи", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 117.0, "Жареное", "Фруктовое", "Перец", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 57.0, "Мясное", "Молочное", "Тушенка", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 35.0, "Рыбное", "Овощное", "Паста", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 60.0, "Вареное", "Тушеное", "Торт", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 139.0, "Свежее", "Фруктовое", "Соус", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 211.0, "Фруктовое", "Свежевыжатое", "Орехи", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 107.0, "Натуральное", "Жидкое", "Молоко", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 22.0, "Шоколадное", "Жареное", "Сгущенка", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 224.0, "Мягкое", "Шоколадное", "Сгущенка", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 133.0, "Шоколадное", "Ванильное", "Гречка", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 22.0, "Полезное", "Натуральное", "Хлеб", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 65.0, "Ароматное", "Сырое", "Томаты", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 33.0, "Сырое", "Красивое", "Паста", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 196.0, "Сладкое", "Пряное", "Курица", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 182.0, "Пикантное", "Морское", "Гречка", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 194.0, "Ванильное", "Шоколадное", "Торт", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 87.0, "Морское", "Пшеничное", "Торт", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 142.0, "Морское", "Мясное", "Рыба", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 161.0, "Запеченное", "Постное", "Маргарин", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 170.0, "Мягкое", "Приправленное", "Паста", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 147.0, "Пряное", "Приправленное", "Тушенка", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 37.0, "Питательное", "Натуральное", "Огурцы", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 215.0, "Вкусное", "Овощное", "Мясо", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 174.0, "Вареное", "Квас", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 212.0, "Натуральное", "Жидкое", "Тушенка", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 7.0, "Пшеничное", "Свежевыжатое", "Сахар", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 187.0, "Свежее", "Ароматное", "Огурцы", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 99.0, "Пряное", "Мясное", "Кола", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 79.0, "Фруктовое", "Свежее", "Кетчуп", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 108.0, "Ржаное", "Острое", "Мороженное", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 49.0, "Жареное", "Красивое", "Кетчуп", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 16, 83.0, "Вареное", "Натуральное", "Красное вино" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 126.0, "Соленое", "Фруктовое", "Тушенка", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 233.0, "Сочное", "Рыбное", "Мясо", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 11, 129.0, "Фруктовое", "Соль", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 218.0, "Сладкое", "Фруктовое", "Чай", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 13, 101.0, "Пряное", "Курица", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 67.0, "Запеченное", "Острое", "Паста", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 22.0, "Сырое", "Пряное", "Торт", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 59.0, "Жареное", "Запеченное", "Соль", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 3, 12.0, "Твердое", "Перец", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 48.0, "Ванильное", "Постное", "Пицца", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 181.0, "Ванильное", "Вареное", "Тушенка", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 209.0, "Вареное", "Красивое", "Сгущенка", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 167.0, "Сочное", "Томаты", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 54.0, "Вкусное", "Жареное", "Пицца", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 220.0, "Вкусное", "Вареное", "Морепродукты", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 122.0, "Острое", "Овощное", "Печенье", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 4.0, "Сытное", "Свежевыжатое", "Морковь", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 204.0, "Морское", "Свежее", "Сыр", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 64.0, "Свежее", "Сырое", "Тушенка", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 125.0, "Мягкое", "Острое", "Сахар", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 64.0, "Сытное", "Твердое", "Овощи", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 169.0, "Пикантное", "Полезное", "Курица", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 206.0, "Морское", "Вкусное", "Хлеб", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 25.0, "Свежевыжатое", "Острое", "Паста", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 130.0, "Фруктовое", "Свежее", "Тушенка", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 44.0, "Пшеничное", "Пшеничное", "Сок", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 90.0, "Сырое", "Пшеничное", "Перец", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 248.0, "Молочное", "Нежное", "Молоко", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 162.0, "Морское", "Натуральное", "Квас", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 123.0, "Ароматное", "Сырое", "Фрукты", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 22.0, "Рыбное", "Тушеное", "Макароны", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 135.0, "Мягкое", "Шоколадное", "Яйца", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 32.0, "Ароматное", "Рыбное", "Шоколад", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 107.0, "Свежевыжатое", "Фруктовое", "Паста", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 229.0, "Жареное", "Запеченное", "Рис", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 216.0, "Морское", "Красивое", "Сыр", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 169.0, "Рыбное", "Ванильное", "Пирог", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 142.0, "Сочное", "Сочное", "Мороженное", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 111.0, "Жареное", "Сладкое", "Сахар", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 1.0, "Полезное", "Сладкое", "Шоколад", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 162.0, "Ванильное", "Сладкое", "Красное вино", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 222.0, "Пшеничное", "Соленое", "Картофель", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 79.0, "Ванильное", "Красивое", "Курица", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 10.0, "Молочное", "Питательное", "Печенье", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 145.0, "Вкусное", "Соленое", "Курица", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 5, 142.0, "Пряное", "Рыбное", "Белое вино" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 80.0, "Жареное", "Ванильное", "Кофе", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 31.0, "Сладкое", "Жидкое", "Яйца", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 37.0, "Жареное", "Твердое", "Хлеб", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 73.0, "Красивое", "Пшеничное", "Пельмени", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 98.0, "Сытное", "Жидкое", "Томаты", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 67.0, "Вкусное", "Сытное", "Каша", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 211.0, "Шоколадное", "Сладкое", "Сахар", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 149.0, "Мясное", "Пряное", "Сок", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 202.0, "Мясное", "Запеченное", "Сахар", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 156.0, "Ржаное", "Пшеничное", "Каша", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 167.0, "Жидкое", "Фруктовое", "Мясо", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 7.0, "Сочное", "Ржаное", "Кола", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 88.0, "Пикантное", "Ванильное", "Пельмени", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 163.0, "Приправленное", "Красивое", "Томаты", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 65.0, "Рыбное", "Острое", "Кофе", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 164.0, "Свежевыжатое", "Твердое", "Молоко", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 9, 43.0, "Молочное", "Белое вино", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 10, 226.0, "Мясное", "Рыба", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 5, 57.0, "Шоколадное", "Пирог", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 167.0, "Приправленное", "Сладкое", "Мороженное", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 4.0, "Ванильное", "Твердое", "Каша", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 201.0, "Ванильное", "Мясное", "Каша", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 126.0, "Запеченное", "Соленое", "Картофель", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 205.0, "Ароматное", "Тушеное", "Чай", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 175.0, "Шоколадное", "Запеченное", "Кекс", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 15.0, "Вареное", "Твердое", "Каша", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 71.0, "Мясное", "Огурцы", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 6.0, "Постное", "Жареное", "Соус", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 161.0, "Острое", "Твердое", "Сгущенка", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 208.0, "Сочное", "Мясное", "Пельмени", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 159.0, "Соленое", "Запеченное", "Пельмени", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 58.0, "Запеченное", "Жареное", "Майонез", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 196.0, "Овощное", "Сырое", "Фрукты", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 143.0, "Медовое", "Ванильное", "Кола", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 167.0, "Рыбное", "Вкусное", "Овощи", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 76.0, "Медовое", "Свежее", "Мороженное", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 5, 76.0, "Овощное", "Вареное", "Салат" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 2, 191.0, "Молочное", "Кекс", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 5.0, "Сладкое", "Нежное", "Пирог", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 227.0, "Рыбное", "Кола", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 101.0, "Морское", "Ароматное", "Тушенка", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 159.0, "Нежное", "Пикантное", "Огурцы", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 138.0, "Шоколадное", "Сладкое", "Печенье", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 119.0, "Сладкое", "Мягкое", "Овощи", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 2.0, "Сытное", "Шоколадное", "Огурцы", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 144.0, "Постное", "Жареное", "Овощи", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 9, 149.0, "Свежевыжатое", "Питательное", "Шоколад" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 107.0, "Вкусное", "Нежное", "Торт", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 224.0, "Мягкое", "Пшеничное", "Шоколад", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 35.0, "Свежее", "Сладкое", "Курица", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 75.0, "Пряное", "Красивое", "Молоко", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 16.0, "Свежее", "Сытное", "Белое вино", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 60.0, "Сочное", "Овощное", "Соль", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 139.0, "Шоколадное", "Шоколадное", "Сок", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 156.0, "Сырое", "Ванильное", "Соус", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 22.0, "Тушеное", "Твердое", "Фрукты", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 160.0, "Жидкое", "Запеченное", "Шоколад", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 181.0, "Фруктовое", "Сырое", "Томаты", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 5.0, "Морское", "Запеченное", "Курица", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 3.0, "Пикантное", "Приправленное", "Маргарин", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 41.0, "Молочное", "Приправленное", "Мед", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 8, 75.0, "Соленое", "Натуральное", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 79.0, "Нежное", "Жидкое", "Томаты", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 18, 215.0, "Ароматное", "Ароматное", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 167.0, "Мясное", "Вареное", "Пирог", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 52.0, "Сладкое", "Жидкое", "Пицца", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 37.0, "Красивое", "Приправленное", "Сгущенка", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 41.0, "Полезное", "Приправленное", "Кекс", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 17, 209.0, "Сытное", "Каша", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 133.0, "Полезное", "Морское", "Фрукты", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 163.0, "Медовое", "Фруктовое", "Макароны", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 10.0, "Постное", "Питательное", "Морковь", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 226.0, "Жидкое", "Пряное", "Огурцы", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 96.0, "Ржаное", "Ванильное", "Макароны", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 221.0, "Сытное", "Сочное", "Сахар", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 228.0, "Мясное", "Запеченное", "Рыба", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 192.0, "Молочное", "Молочное", "Соус", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 194.0, "Ароматное", "Мягкое", "Рис", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 212.0, "Сырое", "Пикантное", "Маргарин", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 88.0, "Медовое", "Сочное", "Мороженное", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 71.0, "Жареное", "Ванильное", "Хлеб", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 165.0, "Тушеное", "Пряное", "Вода", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 128.0, "Молочное", "Морское", "Чай", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 225.0, "Сытное", "Сочное", "Соль", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 186.0, "Ванильное", "Тушеное", "Кекс", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 209.0, "Сочное", "Сладкое", "Паста", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 175.0, "Ржаное", "Сырое", "Яйца", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 207.0, "Жареное", "Питательное", "Кола", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 231.0, "Ванильное", "Свежее", "Фрукты", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 84.0, "Вкусное", "Сырое", "Огурцы", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 193.0, "Фруктовое", "Свежее", "Салат", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 73.0, "Жареное", "Чай", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 15.0, "Ржаное", "Соленое", "Красное вино", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 68.0, "Твердое", "Мясное", "Майонез", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 14, 39.0, "Жареное", "Сок", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 192.0, "Сладкое", "Сочное", "Пельмени", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 188.0, "Молочное", "Сытное", "Маргарин", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 83.0, "Сырое", "Полезное", "Огурцы", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 109.0, "Медовое", "Свежее", "Молоко", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 41.0, "Соленое", "Пикантное", "Хлеб", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 85.0, "Приправленное", "Соленое", "Мясо", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 29.0, "Медовое", "Морское", "Кетчуп", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 208.0, "Нежное", "Ароматное", "Пицца", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 12, 140.0, "Ржаное", "Приправленное", "Курица" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 194.0, "Морское", "Молочное", "Печенье", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 70.0, "Пикантное", "Приправленное", "Сахар", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 244.0, "Морское", "Ванильное", "Молоко", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 77.0, "Питательное", "Пшеничное", "Каша", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 154.0, "Свежее", "Приправленное", "Сок", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 12, 48.0, "Мясное", "Жидкое", "Гречка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 50.0, "Нежное", "Тушеное", "Пирог", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 236.0, "Ржаное", "Вкусное", "Чай", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 221.0, "Пикантное", "Ванильное", "Маргарин", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 62.0, "Острое", "Приправленное", "Вода", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 37.0, "Вкусное", "Рыбное", "Чай", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 11.0, "Рыбное", "Шоколадное", "Рис", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 83.0, "Жареное", "Пряное", "Кола", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 203.0, "Рыбное", "Вкусное", "Квас", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 84.0, "Вареное", "Пицца", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 243.0, "Приправленное", "Ароматное", "Пицца", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 47.0, "Медовое", "Красивое", "Хлеб", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 121.0, "Сладкое", "Соленое", "Салат", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 95.0, "Жареное", "Пряное", "Морепродукты", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 91.0, "Сытное", "Острое", "Салат", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 129.0, "Питательное", "Красивое", "Соус", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 89.0, "Ароматное", "Вареное", "Рис", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 136.0, "Рыбное", "Ванильное", "Макароны", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 233.0, "Ванильное", "Морское", "Курица", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 76.0, "Запеченное", "Свежевыжатое", "Тушенка", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 113.0, "Мягкое", "Питательное", "Перец", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 63.0, "Питательное", "Морское", "Маргарин", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 232.0, "Морское", "Нежное", "Рыба", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 51.0, "Сытное", "Приправленное", "Шоколад", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 133.0, "Приправленное", "Сладкое", "Яйца", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 225.0, "Вкусное", "Запеченное", "Салат", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 198.0, "Пикантное", "Сладкое", "Перец", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 27.0, "Молочное", "Соленое", "Майонез", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 88.0, "Сытное", "Твердое", "Сыр", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 238.0, "Пикантное", "Морское", "Гречка", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 222.0, "Красивое", "Мясное", "Мед", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 113.0, "Запеченное", "Запеченное", "Огурцы", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 169.0, "Вареное", "Сочное", "Белое вино", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 12, 94.0, "Вкусное", "Пикантное", "Салат" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 245.0, "Пшеничное", "Вареное", "Сахар", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 140.0, "Пшеничное", "Нежное", "Торт", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 163.0, "Свежевыжатое", "Рыбное", "Пирог", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 12, 189.0, "Ржаное", "Ржаное", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 144.0, "Вареное", "Овощное", "Пицца", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 20.0, "Сытное", "Пряное", "Торт", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 20.0, "Соленое", "Запеченное", "Морепродукты", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 43.0, "Приправленное", "Полезное", "Мясо", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 115.0, "Рыбное", "Ржаное", "Тушенка", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 25.0, "Морское", "Рыбное", "Кофе", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 88.0, "Запеченное", "Жидкое", "Тушенка", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 141.0, "Жидкое", "Сытное", "Рис", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 221.0, "Нежное", "Постное", "Рис", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 17, 3.0, "Морское", "Фруктовое", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 198.0, "Твердое", "Ржаное", "Рыба", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 34.0, "Приправленное", "Сочное", "Мед", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 18.0, "Мягкое", "Свежее", "Вода", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 98.0, "Жидкое", "Ароматное", "Кекс", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 161.0, "Сырое", "Запеченное", "Морковь", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 1.0, "Ароматное", "Тушеное", "Гречка", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 82.0, "Фруктовое", "Свежее", "Молоко", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "SpecialNote" },
                values: new object[] { 1, 41.0, "Сладкое", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 38.0, "Пряное", "Овощное", "Орехи", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 98.0, "Ванильное", "Ванильное", "Каша", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 206.0, "Фруктовое", "Вареное", "Томаты", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 75.0, "Нежное", "Мягкое", "Рис", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 171.0, "Пикантное", "Медовое", "Мясо", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 226.0, "Фруктовое", "Мясное", "Соус", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 20.0, "Шоколадное", "Сладкое", "Каша", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 215.0, "Сытное", "Полезное", "Квас", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 123.0, "Мясное", "Сладкое", "Морепродукты", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 219.0, "Жидкое", "Рыбное", "Шоколад", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 97.0, "Пряное", "Запеченное", "Перец", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 217.0, "Твердое", "Морское", "Орехи", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 118.0, "Сладкое", "Острое", "Мороженное", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 108.0, "Красивое", "Пшеничное", "Мясо", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 156.0, "Запеченное", "Вкусное", "Кофе", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 233.0, "Вареное", "Мясное", "Кола", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 164.0, "Сладкое", "Медовое", "Кекс", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 10, 18.0, "Ржаное", "Тушеное", "Кола" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 190.0, "Сырое", "Постное", "Морковь", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 225.0, "Мягкое", "Шоколадное", "Морепродукты", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 239.0, "Фруктовое", "Острое", "Торт", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 141.0, "Свежее", "Натуральное", "Гречка", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 18, 172.0, "Свежее", "Рыбное", "Соль" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 51.0, "Красивое", "Жареное", "Мясо", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 151.0, "Жидкое", "Сладкое", "Картофель", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 140.0, "Вкусное", "Вкусное", "Перец", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 40.0, "Шоколадное", "Кекс", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 86.0, "Шоколадное", "Острое", "Красное вино", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 94.0, "Натуральное", "Сладкое", "Соус", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 221.0, "Острое", "Приправленное", "Соус", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 113.0, "Морское", "Пшеничное", "Чай", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote" },
                values: new object[] { 4, 166.0, "Свежее", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 10.0, "Вареное", "Питательное", "Красное вино", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 27.0, "Твердое", "Шоколадное", "Макароны", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 242.0, "Питательное", "Жареное", "Мед", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 9, 111.0, "Нежное", "Овощное", "Гречка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 103.0, "Медовое", "Натуральное", "Томаты", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 12, 4.0, "Приправленное", "Приправленное", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 217.0, "Пикантное", "Сладкое", "Овощи", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 36.0, "Сладкое", "Фруктовое", "Перец", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 215.0, "Сладкое", "Натуральное", "Каша", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 1.0, "Питательное", "Пикантное", "Огурцы", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 222.0, "Жидкое", "Ванильное", "Салат", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 11.0, "Твердое", "Сочное", "Кофе", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 176.0, "Натуральное", "Ванильное", "Курица", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 8, 232.0, "Запеченное", "Постное", "Соус" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 94.0, "Сладкое", "Медовое", "Сыр", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 248.0, "Запеченное", "Пикантное", "Сок", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 172.0, "Медовое", "Вкусное", "Макароны", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 1.0, "Запеченное", "Пряное", "Хлеб", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 4, 183.0, "Натуральное", "Ржаное", "Соль" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 208.0, "Сладкое", "Мягкое", "Чай", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 164.0, "Сочное", "Шоколадное", "Молоко", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 249.0, "Ржаное", "Натуральное", "Фрукты", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 131.0, "Ароматное", "Ароматное", "Овощи", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 38.0, "Сладкое", "Сладкое", "Белое вино", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 130.0, "Овощное", "Натуральное", "Овощи", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 153.0, "Фруктовое", "Морское", "Чай", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 232.0, "Пряное", "Сочное", "Каша", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 91.0, "Шоколадное", "Натуральное", "Торт", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 121.0, "Ароматное", "Ржаное", "Шоколад", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 205.0, "Молочное", "Свежевыжатое", "Красное вино", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 60.0, "Постное", "Сытное", "Вода", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 66.0, "Натуральное", "Шоколадное", "Паста", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 228.0, "Твердое", "Натуральное", "Тушенка", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 231.0, "Сладкое", "Соленое", "Пицца", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 220.0, "Пшеничное", "Ароматное", "Огурцы", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 106.0, "Морское", "Сочное", "Макароны", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 176.0, "Запеченное", "Острое", "Томаты", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 184.0, "Сырое", "Шоколад", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 214.0, "Твердое", "Мясное", "Мед", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 97.0, "Жидкое", "Ржаное", "Мед", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 238.0, "Вареное", "Полезное", "Яйца", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 247.0, "Ржаное", "Рыба", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 67.0, "Морское", "Шоколадное", "Овощи", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 241.0, "Запеченное", "Морское", "Томаты", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 56.0, "Пикантное", "Сырое", "Морепродукты", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 70.0, "Полезное", "Приправленное", "Шоколад", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 97.0, "Рыбное", "Шоколад", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 222.0, "Приправленное", "Мягкое", "Кофе", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 12, 212.0, "Пряное", "Фруктовое", "Шоколад" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 234.0, "Мягкое", "Запеченное", "Шоколад", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 83.0, "Сладкое", "Вареное", "Торт", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 194.0, "Свежевыжатое", "Приправленное", "Кекс", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 72.0, "Приправленное", "Гречка", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 90.0, "Свежее", "Приправленное", "Чай", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 71.0, "Натуральное", "Красивое", "Квас", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 109.0, "Свежевыжатое", "Сырое", "Хлеб", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 177.0, "Нежное", "Натуральное", "Квас", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 100.0, "Мясное", "Питательное", "Пирог", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 1.0, "Острое", "Овощное", "Вода", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 199.0, "Полезное", "Овощное", "Сыр", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 79.0, "Свежевыжатое", "Вареное", "Белое вино", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 208.0, "Тушеное", "Сладкое", "Печенье", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 204.0, "Сочное", "Красивое", "Рис", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 134.0, "Натуральное", "Рыбное", "Шоколад", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 162.0, "Натуральное", "Свежевыжатое", "Каша", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 133.0, "Рыбное", "Молочное", "Каша", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 70.0, "Жидкое", "Красивое", "Кофе", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 154.0, "Пикантное", "Пшеничное", "Морепродукты", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 14, 72.0, "Сырое", "Томаты", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 42.0, "Рыбное", "Ванильное", "Перец", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 33.0, "Мягкое", "Ароматное", "Пирог", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 78.0, "Сырое", "Фруктовое", "Фрукты", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 100.0, "Запеченное", "Тушеное", "Овощи", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 54.0, "Полезное", "Пшеничное", "Огурцы", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 22.0, "Сладкое", "Постное", "Соус", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 140.0, "Шоколадное", "Рыбное", "Пельмени", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 58.0, "Запеченное", "Питательное", "Рис", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 106.0, "Вкусное", "Медовое", "Мясо", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 17.0, "Морское", "Острое", "Сгущенка", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 189.0, "Вареное", "Морское", "Сахар", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 81.0, "Рыбное", "Вареное", "Сахар", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 106.0, "Пшеничное", "Соленое", "Яйца", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 191.0, "Пшеничное", "Пряное", "Курица", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 186.0, "Овощное", "Молочное", "Мясо", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 38.0, "Вкусное", "Ржаное", "Перец", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 91.0, "Красивое", "Свежее", "Печенье", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 1.0, "Рыбное", "Тушеное", "Кола", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 19.0, "Морское", "Острое", "Пицца", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote" },
                values: new object[] { 3, 232.0, "Острое", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 8.0, "Свежее", "Сытное", "Огурцы", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 153.0, "Пикантное", "Сок", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 135.0, "Питательное", "Натуральное", "Морковь", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 139.0, "Рыбное", "Овощное", "Фрукты", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 151.0, "Натуральное", "Свежевыжатое", "Кофе", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 90.0, "Соленое", "Постное", "Соль", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 74.0, "Запеченное", "Мясное", "Гречка", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "SpecialNote" },
                values: new object[] { 17, 8.0, "Вкусное", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 28.0, "Жареное", "Вареное", "Томаты", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 36.0, "Ароматное", "Ванильное", "Макароны", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 122.0, "Мясное", "Вкусное", "Пицца", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 165.0, "Вареное", "Запеченное", "Кекс", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 200.0, "Пряное", "Постное", "Белое вино", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 33.0, "Натуральное", "Свежевыжатое", "Тушенка", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 72.0, "Вкусное", "Сочное", "Кофе", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 51.0, "Твердое", "Мясное", "Соль", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 87.0, "Постное", "Пшеничное", "Вода", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 76.0, "Пряное", "Натуральное", "Чай", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 204.0, "Красивое", "Пикантное", "Соус", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 51.0, "Соленое", "Медовое", "Тушенка", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 200.0, "Жареное", "Ржаное", "Пицца", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 6.0, "Сытное", "Вареное", "Чай", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 224.0, "Нежное", "Жареное", "Вода", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 36.0, "Соленое", "Запеченное", "Сахар", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 149.0, "Ароматное", "Натуральное", "Тушенка", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 97.0, "Вкусное", "Питательное", "Чай", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 197.0, "Рыбное", "Питательное", "Сахар", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 143.0, "Острое", "Пикантное", "Морепродукты", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 75.0, "Красивое", "Нежное", "Сок", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 125.0, "Постное", "Молочное", "Перец", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 132.0, "Мясное", "Красивое", "Печенье", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 210.0, "Соленое", "Пряное", "Пицца", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 112.0, "Мясное", "Ржаное", "Квас", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 35.0, "Полезное", "Медовое", "Гречка", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 87.0, "Твердое", "Запеченное", "Томаты", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 125.0, "Приправленное", "Питательное", "Курица", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 137.0, "Вареное", "Вареное", "Кола", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 66.0, "Постное", "Ванильное", "Паста", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 193.0, "Пикантное", "Сытное", "Паста", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 27.0, "Полезное", "Шоколадное", "Хлеб", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 232.0, "Ароматное", "Мягкое", "Кофе", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 74.0, "Мясное", "Сочное", "Мороженное", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 10.0, "Постное", "Мясное", "Хлеб", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 164.0, "Фруктовое", "Овощное", "Каша", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 54.0, "Ванильное", "Мясное", "Курица", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 42.0, "Натуральное", "Мясное", "Салат", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 244.0, "Мясное", "Пшеничное", "Рыба", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 114.0, "Острое", "Свежевыжатое", "Паста", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 52.0, "Натуральное", "Питательное", "Картофель", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 202.0, "Вкусное", "Ржаное", "Мороженное", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 148.0, "Пикантное", "Пшеничное", "Мед", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 182.0, "Питательное", "Сладкое", "Курица", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 143.0, "Сырое", "Овощное", "Сок", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 26.0, "Пряное", "Свежее", "Кола", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 234.0, "Свежевыжатое", "Твердое", "Хлеб", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 44.0, "Мясное", "Сырое", "Тушенка", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 21.0, "Вареное", "Морское", "Вода", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 79.0, "Молочное", "Красивое", "Вода", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 186.0, "Питательное", "Шоколадное", "Кетчуп", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 152.0, "Рыбное", "Сладкое", "Рыба", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 42.0, "Натуральное", "Соленое", "Фрукты", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 178.0, "Ржаное", "Рыбное", "Огурцы", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 241.0, "Нежное", "Жидкое", "Печенье", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 28.0, "Морское", "Сахар", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 126.0, "Сладкое", "Мягкое", "Огурцы", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 84.0, "Свежее", "Сочное", "Белое вино", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 22.0, "Питательное", "Приправленное", "Кола", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 77.0, "Вкусное", "Ржаное", "Кекс", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 89.0, "Тушеное", "Морское", "Квас", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 114.0, "Сладкое", "Пряное", "Соус", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 97.0, "Сытное", "Молоко", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 15, 157.0, "Морское", "Свежее", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 170.0, "Морское", "Пшеничное", "Хлеб", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 218.0, "Сладкое", "Рыбное", "Яйца", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 31.0, "Мягкое", "Рыбное", "Мед", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 243.0, "Рыбное", "Жареное", "Курица", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 233.0, "Морское", "Жареное", "Кетчуп", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 109.0, "Острое", "Сочное", "Фрукты", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 9, 23.0, "Полезное", "Пикантное", "Картофель" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 63.0, "Тушеное", "Жидкое", "Рис", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 18, 166.0, "Вареное", "Квас", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 199.0, "Свежее", "Жареное", "Курица", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 20.0, "Мясное", "Натуральное", "Яйца", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 69.0, "Свежевыжатое", "Ржаное", "Перец", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 153.0, "Соленое", "Фруктовое", "Курица", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 168.0, "Жидкое", "Пшеничное", "Рис", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 8, 186.0, "Запеченное", "Овощное", "Кола" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 135.0, "Вареное", "Постное", "Маргарин", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 123.0, "Медовое", "Морское", "Рыба", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 129.0, "Ароматное", "Ржаное", "Кола", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 113.0, "Сытное", "Пшеничное", "Овощи", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 239.0, "Полезное", "Пряное", "Огурцы", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 245.0, "Молочное", "Острое", "Сгущенка", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 191.0, "Твердое", "Жареное", "Морковь", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 29.0, "Постное", "Нежное", "Рис", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 175.0, "Шоколадное", "Острое", "Торт", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 160.0, "Медовое", "Острое", "Тушенка", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 43.0, "Мясное", "Фруктовое", "Паста", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 248.0, "Натуральное", "Сочное", "Тушенка", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 233.0, "Нежное", "Питательное", "Печенье", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 11.0, "Ванильное", "Вкусное", "Томаты", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 9.0, "Мягкое", "Жидкое", "Квас", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 137.0, "Соленое", "Соленое", "Сыр", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 33.0, "Полезное", "Полезное", "Белое вино", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 106.0, "Сытное", "Шоколадное", "Морепродукты", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 187.0, "Морское", "Фруктовое", "Гречка", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 80.0, "Полезное", "Овощное", "Сыр", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 145.0, "Мясное", "Свежевыжатое", "Шоколад", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 200.0, "Пшеничное", "Сырое", "Рыба", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 222.0, "Пикантное", "Нежное", "Соус", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 178.0, "Ванильное", "Ванильное", "Маргарин", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 6.0, "Питательное", "Ванильное", "Перец", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 63.0, "Ржаное", "Твердое", "Рис", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 35.0, "Твердое", "Нежное", "Мороженное", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 61.0, "Жареное", "Мягкое", "Макароны", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 23.0, "Пикантное", "Мед", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 181.0, "Рыбное", "Сытное", "Мед", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 111.0, "Пшеничное", "Приправленное", "Мясо", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 222.0, "Натуральное", "Свежее", "Перец", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 226.0, "Красивое", "Нежное", "Каша", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 51.0, "Ароматное", "Сытное", "Морепродукты", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 11.0, "Сочное", "Нежное", "Мороженное", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 97.0, "Ржаное", "Сочное", "Огурцы", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 226.0, "Питательное", "Острое", "Томаты", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 155.0, "Свежее", "Ржаное", "Морепродукты", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 42.0, "Пшеничное", "Тушеное", "Рис", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 80.0, "Нежное", "Сладкое", "Паста", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 49.0, "Сытное", "Свежевыжатое", "Сгущенка", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 196.0, "Пряное", "Сытное", "Соус", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 126.0, "Сладкое", "Сладкое", "Кекс", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 111.0, "Твердое", "Шоколадное", "Вода", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 85.0, "Тушеное", "Пикантное", "Мед", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 117.0, "Сладкое", "Жидкое", "Белое вино", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 78.0, "Вкусное", "Жидкое", "Молоко", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 28.0, "Сладкое", "Мясное", "Перец", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 110.0, "Твердое", "Жидкое", "Рыба", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 141.0, "Шоколадное", "Шоколадное", "Мед", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 18.0, "Ржаное", "Овощное", "Кофе", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 118.0, "Твердое", "Медовое", "Соус", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 9, 160.0, "Острое", "Молочное", "Орехи" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 13.0, "Твердое", "Рыбное", "Тушенка", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 22.0, "Шоколадное", "Медовое", "Молоко", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 206.0, "Твердое", "Шоколадное", "Белое вино", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 5, 18.0, "Натуральное", "Мягкое", "Кола" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 165.0, "Острое", "Приправленное", "Гречка", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 90.0, "Свежее", "Твердое", "Перец", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 161.0, "Ароматное", "Приправленное", "Пирог", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 171.0, "Молочное", "Тушеное", "Мясо", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 183.0, "Свежевыжатое", "Ржаное", "Кетчуп", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 98.0, "Сладкое", "Сырое", "Морковь", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 115.0, "Жидкое", "Жидкое", "Курица", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 142.0, "Медовое", "Шоколадное", "Курица", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 122.0, "Сладкое", "Пшеничное", "Красное вино", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 106.0, "Полезное", "Фруктовое", "Красное вино", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 98.0, "Острое", "Пикантное", "Кекс", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 3.0, "Ржаное", "Жареное", "Перец", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 104.0, "Свежевыжатое", "Ароматное", "Печенье", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 46.0, "Полезное", "Пшеничное", "Курица", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 219.0, "Пикантное", "Вареное", "Хлеб", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 140.0, "Нежное", "Пшеничное", "Пельмени", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 3, 218.0, "Твердое", "Торт", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 147.0, "Сладкое", "Сгущенка", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 163.0, "Сырое", "Тушеное", "Овощи", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 13.0, "Вкусное", "Вкусное", "Пельмени", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 80.0, "Рыбное", "Фруктовое", "Рыба", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 228.0, "Фруктовое", "Ржаное", "Фрукты", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 5, 163.0, "Запеченное", "Красивое", "Сгущенка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 207.0, "Мясное", "Жареное", "Пирог", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 9, 226.0, "Твердое", "Жареное", "Красное вино" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 224.0, "Пикантное", "Чай", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 42.0, "Фруктовое", "Овощное", "Макароны", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 90.0, "Фруктовое", "Мягкое", "Кола", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 176.0, "Свежевыжатое", "Ржаное", "Майонез", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 244.0, "Соленое", "Сырое", "Овощи", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 178.0, "Острое", "Морское", "Маргарин", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 175.0, "Свежее", "Мягкое", "Печенье", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 38.0, "Молочное", "Ванильное", "Салат", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 53.0, "Красивое", "Медовое", "Кофе", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 147.0, "Приправленное", "Фруктовое", "Квас", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 75.0, "Ароматное", "Овощное", "Фрукты", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 113.0, "Сочное", "Твердое", "Орехи", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 27.0, "Мягкое", "Пикантное", "Маргарин", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 75.0, "Тушеное", "Вкусное", "Кетчуп", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 223.0, "Полезное", "Натуральное", "Майонез", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 164.0, "Постное", "Ржаное", "Мороженное", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 79.0, "Молочное", "Соленое", "Красное вино", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 203.0, "Пряное", "Твердое", "Фрукты", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 105.0, "Жареное", "Пикантное", "Перец", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 47.0, "Твердое", "Сырое", "Морковь", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 37.0, "Мясное", "Соленое", "Сахар", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 215.0, "Сырое", "Соленое", "Перец", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 35.0, "Ржаное", "Ржаное", "Майонез", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 18.0, "Запеченное", "Постное", "Мед", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 150.0, "Вареное", "Пряное", "Кола", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 167.0, "Фруктовое", "Постное", "Пирог", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 62.0, "Мягкое", "Сырое", "Пирог", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 107.0, "Свежевыжатое", "Твердое", "Курица", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 17.0, "Фруктовое", "Вареное", "Фрукты", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 112.0, "Полезное", "Фруктовое", "Кекс", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 218.0, "Нежное", "Сладкое", "Чай", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 62.0, "Твердое", "Тушеное", "Молоко", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 146.0, "Ароматное", "Молочное", "Рис", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 48.0, "Постное", "Пикантное", "Яйца", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 86.0, "Постное", "Медовое", "Квас", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 148.0, "Тушеное", "Ржаное", "Шоколад", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 123.0, "Жареное", "Сочное", "Каша", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 221.0, "Рыбное", "Красивое", "Вода", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 177.0, "Пшеничное", "Овощное", "Сахар", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 94.0, "Соленое", "Питательное", "Чай", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 156.0, "Острое", "Медовое", "Кекс", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 17, 129.0, "Сладкое", "Пирог", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 176.0, "Запеченное", "Мягкое", "Кетчуп", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 23.0, "Фруктовое", "Ванильное", "Печенье", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 53.0, "Рыбное", "Натуральное", "Перец", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 197.0, "Морское", "Красивое", "Торт", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 173.0, "Свежевыжатое", "Натуральное", "Кола", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 126.0, "Острое", "Сытное", "Морепродукты", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 104.0, "Ванильное", "Медовое", "Хлеб", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 87.0, "Соленое", "Полезное", "Квас", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 207.0, "Ржаное", "Свежевыжатое", "Рыба", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 156.0, "Приправленное", "Свежевыжатое", "Морковь", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 18.0, "Пряное", "Мягкое", "Белое вино", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 40.0, "Соленое", "Питательное", "Тушенка", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 11, 138.0, "Сладкое", "Острое", "Сахар" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 91.0, "Шоколадное", "Рыбное", "Квас", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 25.0, "Постное", "Пшеничное", "Гречка", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 20.0, "Фруктовое", "Жидкое", "Майонез", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 142.0, "Острое", "Питательное", "Соус", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote" },
                values: new object[] { 12, 61.0, "Нежное", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 145.0, "Ароматное", "Жидкое", "Макароны", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 21.0, "Ванильное", "Фруктовое", "Мороженное", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 43.0, "Сладкое", "Сочное", "Овощи", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 6, 141.0, "Ароматное", "Сочное", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 59.0, "Тушеное", "Пряное", "Фрукты", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 120.0, "Шоколадное", "Сочное", "Маргарин", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 173.0, "Медовое", "Свежевыжатое", "Сыр", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 222.0, "Нежное", "Полезное", "Соус", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 72.0, "Сырое", "Полезное", "Тушенка", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 5.0, "Жидкое", "Молочное", "Белое вино", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 153.0, "Овощное", "Соленое", "Хлеб", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 12, 180.0, "Морское", "Огурцы", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 207.0, "Соленое", "Пшеничное", "Огурцы", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 126.0, "Сладкое", "Твердое", "Курица", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 64.0, "Нежное", "Сладкое", "Сахар", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 124.0, "Запеченное", "Медовое", "Морепродукты", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 206.0, "Пшеничное", "Вареное", "Сок", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 16.0, "Мягкое", "Ароматное", "Шоколад", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 103.0, "Свежее", "Свежевыжатое", "Кекс", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 166.0, "Мягкое", "Ароматное", "Маргарин", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 161.0, "Морское", "Пшеничное", "Фрукты", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 25.0, "Ванильное", "Тушеное", "Чай", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 45.0, "Молочное", "Питательное", "Белое вино", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 49.0, "Постное", "Острое", "Яйца", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 36.0, "Полезное", "Постное", "Салат", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 44.0, "Овощное", "Тушеное", "Сгущенка", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 93.0, "Нежное", "Острое", "Каша", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 194.0, "Ванильное", "Пряное", "Мясо", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 109.0, "Приправленное", "Вареное", "Перец", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 34.0, "Пикантное", "Ванильное", "Сгущенка", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 64.0, "Жареное", "Нежное", "Морковь", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 196.0, "Ароматное", "Постное", "Салат", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 207.0, "Соленое", "Свежевыжатое", "Сок", "Морское" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBlocked",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 231.0, "Медовое", "Питательное", "Печенье", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 23.0, "Постное", "Острое", "Курица", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 76.0, "Постное", "Мясное", "Торт", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 56.0, "Питательное", "Натуральное", "Шоколад", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 66.0, "Полезное", "Фруктовое", "Вода", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 78.0, "Мясное", "Ржаное", "Рыба", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 215.0, "Постное", "Свежевыжатое", "Макароны", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 98.0, "Острое", "Вкусное", "Томаты", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 214.0, "Постное", "Острое", "Маргарин", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 23.0, "Рыбное", "Пикантное", "Тушенка", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 194.0, "Сочное", "Ароматное", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 9.0, "Пикантное", "Вкусное", "Маргарин", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 113.0, "Острое", "Пикантное", "Чай", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 5.0, "Фруктовое", "Запеченное", "Орехи", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 127.0, "Пшеничное", "Запеченное", "Макароны", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 86.0, "Твердое", "Острое", "Рыба", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 174.0, "Шоколадное", "Кетчуп", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 224.0, "Ароматное", "Нежное", "Кофе", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 86.0, "Натуральное", "Сладкое", "Тушенка", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 217.0, "Сладкое", "Ароматное", "Маргарин", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 108.0, "Жидкое", "Запеченное", "Гречка", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 248.0, "Пряное", "Сытное", "Гречка", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 38.0, "Запеченное", "Твердое", "Красное вино", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 40.0, "Медовое", "Морковь", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 60.0, "Питательное", "Медовое", "Морепродукты", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 223.0, "Запеченное", "Нежное", "Перец", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 147.0, "Сырое", "Морское", "Яйца", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 204.0, "Ванильное", "Натуральное", "Гречка", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 150.0, "Нежное", "Натуральное", "Салат", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 231.0, "Молочное", "Морское", "Сахар", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 219.0, "Свежевыжатое", "Жареное", "Перец", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 76.0, "Приправленное", "Мягкое", "Соус", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 117.0, "Ржаное", "Жареное", "Вода", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 14.0, "Медовое", "Нежное", "Фрукты", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 63.0, "Шоколадное", "Полезное", "Мороженное", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 124.0, "Натуральное", "Твердое", "Молоко", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 5.0, "Пряное", "Овощное", "Пицца", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 231.0, "Морское", "Натуральное", "Салат", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 8, 223.0, "Красивое", "Вкусное", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 165.0, "Жареное", "Пряное", "Майонез", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 194.0, "Полезное", "Питательное", "Сгущенка", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 64.0, "Твердое", "Сладкое", "Красное вино", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 70.0, "Фруктовое", "Медовое", "Мороженное", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 216.0, "Пшеничное", "Фруктовое", "Соль", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 106.0, "Острое", "Питательное", "Пицца", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 201.0, "Медовое", "Пикантное", "Гречка", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 49.0, "Питательное", "Сытное", "Пицца", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 219.0, "Сырое", "Вкусное", "Молоко", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 225.0, "Вкусное", "Пшеничное", "Соль", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 66.0, "Свежее", "Нежное", "Мед", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 100.0, "Натуральное", "Ржаное", "Курица", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 155.0, "Сытное", "Запеченное", "Пельмени", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 203.0, "Сочное", "Соленое", "Морепродукты", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 142.0, "Вареное", "Постное", "Соль", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 89.0, "Питательное", "Мясное", "Сок", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 166.0, "Ароматное", "Мягкое", "Паста", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 69.0, "Вкусное", "Пшеничное", "Огурцы", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 23.0, "Соленое", "Ржаное", "Рис", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 10, 80.0, "Постное", "Сгущенка", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 191.0, "Пикантное", "Ванильное", "Кофе", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 37.0, "Острое", "Молочное", "Шоколад", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 218.0, "Ароматное", "Ржаное", "Пельмени", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 66.0, "Фруктовое", "Ванильное", "Салат", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 1.0, "Сочное", "Натуральное", "Соус", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 48.0, "Пикантное", "Запеченное", "Морковь", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 42.0, "Молочное", "Красивое", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 2.0, "Овощное", "Вкусное", "Овощи", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 143.0, "Свежевыжатое", "Шоколадное", "Яйца", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 35.0, "Сырое", "Свежее", "Кола", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 93.0, "Нежное", "Соленое", "Молоко", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 84.0, "Сытное", "Сытное", "Кекс", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 238.0, "Молочное", "Пшеничное", "Морепродукты", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 115.0, "Натуральное", "Сочное", "Пельмени", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 69.0, "Питательное", "Жареное", "Паста", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 230.0, "Овощное", "Пшеничное", "Орехи", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 33.0, "Мягкое", "Соленое", "Пирог", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 246.0, "Красивое", "Рыбное", "Мороженное", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 210.0, "Рыбное", "Жидкое", "Яйца", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 4.0, "Питательное", "Мягкое", "Рис", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 172.0, "Тушеное", "Рыбное", "Кофе", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 2, 155.0, "Сырое", "Мясное", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 242.0, "Вкусное", "Сытное", "Рыба", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 169.0, "Приправленное", "Полезное", "Сок", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 14, 25.0, "Свежее", "Тушеное", "Рис" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 10.0, "Овощное", "Мягкое", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 54.0, "Фруктовое", "Овощное", "Рыба", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 223.0, "Запеченное", "Свежее", "Фрукты", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 207.0, "Медовое", "Сладкое", "Хлеб", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 236.0, "Шоколадное", "Вкусное", "Квас", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 1, 152.0, "Рыбное", "Кетчуп", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 145.0, "Ванильное", "Натуральное", "Хлеб", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 17, 65.0, "Шоколадное", "Полезное", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 24.0, "Сырое", "Сочное", "Морковь", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 234.0, "Острое", "Тушеное", "Макароны", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 233.0, "Ржаное", "Мясное", "Сыр", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 146.0, "Фруктовое", "Питательное", "Рыба", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 37.0, "Морское", "Пряное", "Кекс", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 103.0, "Вкусное", "Острое", "Морепродукты", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 70.0, "Свежевыжатое", "Молочное", "Паста", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 55.0, "Пряное", "Медовое", "Пицца", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 133.0, "Мясное", "Молочное", "Кекс", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 57.0, "Мясное", "Сладкое", "Кекс", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "SpecialNote" },
                values: new object[] { 16, 196.0, "Сочное", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 99.0, "Питательное", "Свежее", "Сыр", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 180.0, "Нежное", "Пикантное", "Квас", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 6.0, "Пикантное", "Ванильное", "Соус", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 102.0, "Мягкое", "Молочное", "Пирог", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 124.0, "Твердое", "Запеченное", "Майонез", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 47.0, "Твердое", "Полезное", "Вода", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 136.0, "Красивое", "Соленое", "Шоколад", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 189.0, "Сладкое", "Мягкое", "Овощи", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 151.0, "Твердое", "Запеченное", "Майонез", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 131.0, "Тушеное", "Вареное", "Мясо", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 140.0, "Жидкое", "Чай", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 163.0, "Пикантное", "Вкусное", "Красное вино", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 31.0, "Сладкое", "Нежное", "Пицца", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 43.0, "Приправленное", "Ароматное", "Перец", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 83.0, "Рыбное", "Острое", "Картофель", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 110.0, "Сытное", "Запеченное", "Яйца", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 21.0, "Мясное", "Приправленное", "Сок", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 75.0, "Фруктовое", "Сладкое", "Соль", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 78.0, "Свежевыжатое", "Рыбное", "Макароны", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 17, 16.0, "Постное", "Овощи", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 9.0, "Острое", "Пряное", "Морковь", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 236.0, "Овощное", "Тушеное", "Кетчуп", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 232.0, "Мягкое", "Красивое", "Квас", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 166.0, "Жареное", "Постное", "Рыба", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 64.0, "Вкусное", "Овощное", "Пирог", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 107.0, "Сладкое", "Фруктовое", "Соль", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 18.0, "Соленое", "Молочное", "Рис", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 54.0, "Мягкое", "Натуральное", "Томаты", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 184.0, "Жидкое", "Ржаное", "Мед", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 214.0, "Тушеное", "Фруктовое", "Рис", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 206.0, "Нежное", "Постное", "Шоколад", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 19.0, "Фруктовое", "Ванильное", "Соус", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 53.0, "Свежевыжатое", "Мясное", "Кола", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 197.0, "Рыбное", "Твердое", "Сыр", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 235.0, "Вареное", "Ванильное", "Перец", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 81.0, "Пряное", "Приправленное", "Пицца", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 57.0, "Сладкое", "Натуральное", "Орехи", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 21.0, "Приправленное", "Тушеное", "Маргарин", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 76.0, "Мягкое", "Молочное", "Печенье", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 3.0, "Сладкое", "Молочное", "Курица", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 46.0, "Вареное", "Мясное", "Пицца", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 75.0, "Шоколадное", "Морское", "Мясо", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 49.0, "Свежевыжатое", "Пшеничное", "Печенье", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 1, 115.0, "Пряное", "Гречка", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 115.0, "Шоколадное", "Рыбное", "Шоколад", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 5.0, "Ванильное", "Сладкое", "Хлеб", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 101.0, "Сладкое", "Сладкое", "Тушенка", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 14.0, "Твердое", "Овощное", "Мороженное", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 54.0, "Сытное", "Запеченное", "Торт", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 157.0, "Фруктовое", "Острое", "Рыба", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 171.0, "Питательное", "Натуральное", "Красное вино", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 51.0, "Запеченное", "Свежевыжатое", "Пицца", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 154.0, "Ароматное", "Молочное", "Хлеб", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 94.0, "Твердое", "Ржаное", "Рыба", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 127.0, "Вкусное", "Острое", "Морковь", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 30.0, "Ржаное", "Овощное", "Пельмени", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 5, 4.0, "Сырое", "Полезное", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 233.0, "Мягкое", "Жареное", "Мясо", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 32.0, "Приправленное", "Сладкое", "Паста", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 176.0, "Питательное", "Запеченное", "Пельмени", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 164.0, "Приправленное", "Пикантное", "Огурцы", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 124.0, "Жареное", "Сладкое", "Фрукты", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 5.0, "Вареное", "Жидкое", "Овощи", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 88.0, "Сырое", "Сочное", "Сахар", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 60.0, "Овощное", "Красивое", "Красное вино", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 33.0, "Ароматное", "Ароматное", "Морепродукты", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 94.0, "Запеченное", "Соленое", "Тушенка", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 56.0, "Острое", "Сытное", "Чай", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 151.0, "Сочное", "Питательное", "Майонез", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 13.0, "Медовое", "Натуральное", "Красное вино", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 205.0, "Мясное", "Ванильное", "Морепродукты", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 39.0, "Мягкое", "Овощное", "Печенье", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 237.0, "Пряное", "Ржаное", "Пицца", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 212.0, "Постное", "Приправленное", "Молоко", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 17.0, "Сладкое", "Шоколадное", "Каша", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 112.0, "Твердое", "Вареное", "Макароны", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 98.0, "Ржаное", "Торт", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 12, 1.0, "Тушеное", "Каша", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 235.0, "Овощное", "Фруктовое", "Рыба", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 45.0, "Фруктовое", "Тушеное", "Салат", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 157.0, "Молочное", "Сырое", "Соус", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 29.0, "Сочное", "Шоколадное", "Белое вино", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 18.0, "Вареное", "Сладкое", "Салат", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 9, 188.0, "Пряное", "Кофе", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 120.0, "Рыбное", "Сытное", "Кола", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 140.0, "Ванильное", "Свежевыжатое", "Тушенка", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 97.0, "Твердое", "Сочное", "Паста", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 64.0, "Запеченное", "Шоколадное", "Чай", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 40.0, "Рыбное", "Медовое", "Картофель", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 18, 223.0, "Ароматное", "Запеченное", "Рыба" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 165.0, "Ванильное", "Рыбное", "Фрукты", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 121.0, "Мягкое", "Полезное", "Каша", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 165.0, "Молочное", "Молочное", "Маргарин", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 80.0, "Красивое", "Приправленное", "Маргарин", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 88.0, "Постное", "Красивое", "Орехи", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 58.0, "Сладкое", "Сладкое", "Кола", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 237.0, "Молочное", "Сочное", "Пельмени", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 162.0, "Мясное", "Полезное", "Сгущенка", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 86.0, "Питательное", "Ржаное", "Гречка", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 6, 67.0, "Вареное", "Морковь", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 11.0, "Ароматное", "Молочное", "Орехи", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 11.0, "Мягкое", "Красивое", "Вода", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 162.0, "Полезное", "Постное", "Сахар", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10.0, "Вкусное", "Вареное", "Перец", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 135.0, "Острое", "Твердое", "Тушенка", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 113.0, "Ржаное", "Пикантное", "Кекс", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 18.0, "Нежное", "Фруктовое", "Мед", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 4, 237.0, "Вкусное", "Сочное", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 40.0, "Фруктовое", "Вкусное", "Вода", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 15, 176.0, "Жареное", "Натуральное", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 214.0, "Твердое", "Нежное", "Овощи", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 44.0, "Натуральное", "Вареное", "Сахар", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 82.0, "Тушеное", "Свежевыжатое", "Чай", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 38.0, "Жареное", "Красивое", "Мороженное", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 58.0, "Нежное", "Пикантное", "Овощи", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 117.0, "Медовое", "Мясное", "Каша", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 115.0, "Молочное", "Сладкое", "Рыба", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 70.0, "Тушеное", "Пшеничное", "Рыба", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 60.0, "Рыбное", "Приправленное", "Молоко", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 88.0, "Вареное", "Жареное", "Морепродукты", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 163.0, "Сырое", "Сырое", "Мясо", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 121.0, "Приправленное", "Красивое", "Гречка", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 59.0, "Овощное", "Соленое", "Кекс", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 207.0, "Морское", "Вкусное", "Макароны", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 77.0, "Запеченное", "Пикантное", "Сок", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 48.0, "Ароматное", "Сладкое", "Белое вино", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 12.0, "Шоколадное", "Ароматное", "Мороженное", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 12, 76.0, "Ванильное", "Мороженное", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 198.0, "Вкусное", "Шоколадное", "Торт", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 148.0, "Ржаное", "Сладкое", "Морепродукты", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 62.0, "Ароматное", "Вкусное", "Сок", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 14, 78.0, "Вкусное", "Пшеничное", "Макароны" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 195.0, "Жидкое", "Рыбное", "Сыр", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 208.0, "Запеченное", "Ванильное", "Фрукты", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 58.0, "Соленое", "Красивое", "Вода", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 86.0, "Твердое", "Мягкое", "Салат", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 5.0, "Молочное", "Мед", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 249.0, "Сладкое", "Тушеное", "Пельмени", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 204.0, "Красивое", "Рыбное", "Сгущенка", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 80.0, "Запеченное", "Пикантное", "Овощи", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 224.0, "Натуральное", "Твердое", "Курица", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 80.0, "Ароматное", "Шоколадное", "Сахар", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 91.0, "Рыбное", "Запеченное", "Чай", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 125.0, "Шоколадное", "Соленое", "Красное вино", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 194.0, "Ароматное", "Натуральное", "Курица", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 166.0, "Свежее", "Соленое", "Салат", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 220.0, "Мясное", "Красивое", "Сок", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 4, 112.0, "Постное", "Свежевыжатое", "Морепродукты" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 86.0, "Сладкое", "Пшеничное", "Квас", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 132.0, "Запеченное", "Молочное", "Каша", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 2.0, "Запеченное", "Нежное", "Фрукты", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 213.0, "Свежевыжатое", "Свежевыжатое", "Тушенка", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 217.0, "Полезное", "Мясное", "Яйца", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 9.0, "Жареное", "Рыбное", "Майонез", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 92.0, "Вкусное", "Морское", "Кофе", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 229.0, "Ароматное", "Овощи", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 102.0, "Молочное", "Нежное", "Макароны", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 71.0, "Острое", "Нежное", "Кофе", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 243.0, "Шоколадное", "Сытное", "Молоко", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 188.0, "Медовое", "Тушеное", "Кофе", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 92.0, "Овощное", "Мясное", "Томаты", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 185.0, "Твердое", "Острое", "Перец", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 173.0, "Пикантное", "Пикантное", "Каша", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 48.0, "Медовое", "Запеченное", "Вода", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 76.0, "Натуральное", "Шоколадное", "Маргарин", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 10.0, "Жидкое", "Сырое", "Орехи", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 1.0, "Ароматное", "Мягкое", "Сахар", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 144.0, "Жареное", "Тушеное", "Соус", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 126.0, "Свежее", "Жидкое", "Рис", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 24.0, "Питательное", "Пшеничное", "Кофе", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 39.0, "Пшеничное", "Фруктовое", "Перец", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 11, 75.0, "Ржаное", "Паста", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 144.0, "Красивое", "Медовое", "Перец", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 178.0, "Ржаное", "Ванильное", "Курица", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 57.0, "Приправленное", "Нежное", "Макароны", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 10.0, "Свежевыжатое", "Фрукты", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 10.0, "Вкусное", "Молочное", "Сахар", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 18.0, "Вкусное", "Вареное", "Морепродукты", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 152.0, "Жидкое", "Фруктовое", "Печенье", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 69.0, "Сочное", "Жареное", "Соль", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 20.0, "Свежевыжатое", "Сладкое", "Макароны", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 119.0, "Постное", "Острое", "Морковь", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 77.0, "Пикантное", "Приправленное", "Майонез", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 202.0, "Постное", "Нежное", "Макароны", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 167.0, "Шоколадное", "Медовое", "Яйца", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 67.0, "Овощное", "Запеченное", "Перец", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 156.0, "Питательное", "Свежевыжатое", "Майонез", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 245.0, "Жидкое", "Нежное", "Майонез", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 175.0, "Фруктовое", "Жидкое", "Пицца", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 249.0, "Ванильное", "Полезное", "Рыба", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 16, 247.0, "Пикантное", "Томаты", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 89.0, "Питательное", "Свежее", "Картофель", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 41.0, "Свежее", "Вареное", "Перец", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 10.0, "Пикантное", "Шоколадное", "Кола", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 15, 85.0, "Мягкое", "Мороженное", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 227.0, "Полезное", "Питательное", "Сахар", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 81.0, "Мясное", "Жидкое", "Сгущенка", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 95.0, "Сладкое", "Соленое", "Мясо", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 181.0, "Твердое", "Красивое", "Хлеб", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 61.0, "Ванильное", "Соленое", "Мороженное", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 117.0, "Твердое", "Жидкое", "Кетчуп", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 140.0, "Пикантное", "Ароматное", "Сгущенка", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 220.0, "Овощное", "Сладкое", "Шоколад", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 169.0, "Ржаное", "Шоколадное", "Сахар", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 71.0, "Морское", "Ржаное", "Белое вино", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 123.0, "Ванильное", "Приправленное", "Курица", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 157.0, "Сочное", "Шоколадное", "Тушенка", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 15.0, "Сырое", "Пикантное", "Морковь", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 15, 178.0, "Ржаное", "Фруктовое", "Печенье" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 172.0, "Тушеное", "Полезное", "Томаты", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 65.0, "Овощное", "Свежевыжатое", "Кекс", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 166.0, "Сочное", "Кофе", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 157.0, "Твердое", "Жидкое", "Огурцы", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 171.0, "Запеченное", "Мясное", "Молоко", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 14, 23.0, "Свежевыжатое", "Тушеное", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 67.0, "Морское", "Пшеничное", "Пицца", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 145.0, "Пряное", "Молочное", "Курица", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 134.0, "Острое", "Тушеное", "Тушенка", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 29.0, "Острое", "Сочное", "Маргарин", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 186.0, "Ванильное", "Сытное", "Кофе", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 53.0, "Овощное", "Нежное", "Орехи", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 13, 68.0, "Сытное", "Фруктовое", "Орехи" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 73.0, "Натуральное", "Полезное", "Мясо", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 149.0, "Сочное", "Ржаное", "Мороженное", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 128.0, "Сладкое", "Фруктовое", "Морковь", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 202.0, "Свежевыжатое", "Сладкое", "Шоколад", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 108.0, "Рыбное", "Натуральное", "Сыр", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 1.0, "Сладкое", "Сладкое", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 10.0, "Сладкое", "Полезное", "Печенье", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 192.0, "Шоколадное", "Свежевыжатое", "Мед", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 162.0, "Мягкое", "Пшеничное", "Фрукты", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 165.0, "Натуральное", "Соленое", "Красное вино", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 147.0, "Нежное", "Морское", "Сок", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 187.0, "Полезное", "Сладкое", "Соль", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 106.0, "Морское", "Пряное", "Перец", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 92.0, "Жидкое", "Мягкое", "Маргарин", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 238.0, "Молочное", "Фруктовое", "Молоко", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 21.0, "Молочное", "Молочное", "Мед", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 150.0, "Натуральное", "Сытное", "Кетчуп", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 25.0, "Пряное", "Сочное", "Пицца", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 49.0, "Пряное", "Мясное", "Яйца", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 2, 149.0, "Овощное", "Кекс", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 159.0, "Сладкое", "Сладкое", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 149.0, "Питательное", "Фруктовое", "Кекс", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 131.0, "Пшеничное", "Соленое", "Фрукты", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 83.0, "Сочное", "Ржаное", "Рыба", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 188.0, "Пряное", "Постное", "Яйца", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 189.0, "Твердое", "Ржаное", "Кекс", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 82.0, "Пикантное", "Пикантное", "Фрукты", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 127.0, "Сочное", "Нежное", "Фрукты", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 167.0, "Шоколадное", "Вкусное", "Морковь", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 168.0, "Пикантное", "Мягкое", "Томаты", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 114.0, "Вкусное", "Приправленное", "Мед", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 217.0, "Фруктовое", "Рыбное", "Кетчуп", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 39.0, "Молочное", "Сырое", "Чай", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 29.0, "Сочное", "Ржаное", "Салат", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 55.0, "Острое", "Полезное", "Овощи", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 5, 17.0, "Соленое", "Овощное", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 65.0, "Нежное", "Морское", "Макароны", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 88.0, "Запеченное", "Мясное", "Чай", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 124.0, "Питательное", "Сочное", "Салат", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 4, 164.0, "Красивое", "Пряное", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 75.0, "Свежее", "Нежное", "Макароны", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 227.0, "Фруктовое", "Ванильное", "Перец", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 100.0, "Ароматное", "Твердое", "Паста", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 71.0, "Мясное", "Сытное", "Томаты", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 83.0, "Твердое", "Вареное", "Яйца", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 7.0, "Ржаное", "Морское", "Мясо", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 35.0, "Свежевыжатое", "Ванильное", "Огурцы", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 33.0, "Питательное", "Острое", "Салат", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 122.0, "Запеченное", "Сытное", "Картофель", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 202.0, "Молочное", "Вареное", "Пицца", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 49.0, "Рыбное", "Соленое", "Соус", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 219.0, "Вкусное", "Вкусное", "Чай", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 89.0, "Морское", "Шоколадное", "Сахар", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 78.0, "Вкусное", "Вареное", "Каша", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 47.0, "Вареное", "Пряное", "Соль", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 14.0, "Нежное", "Полезное", "Паста", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 36.0, "Свежевыжатое", "Сладкое", "Рис", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 180.0, "Сочное", "Мягкое", "Яйца", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 116.0, "Полезное", "Полезное", "Рис", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 202.0, "Овощное", "Нежное", "Гречка", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 21.0, "Медовое", "Мягкое", "Паста", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 143.0, "Жидкое", "Мясное", "Молоко", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 247.0, "Натуральное", "Сытное", "Кофе", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 23.0, "Приправленное", "Свежее", "Салат", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 86.0, "Пряное", "Мягкое", "Мясо", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 62.0, "Мягкое", "Сладкое", "Кофе", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 67.0, "Запеченное", "Натуральное", "Хлеб", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 101.0, "Фруктовое", "Овощное", "Молоко", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 2.0, "Натуральное", "Мясное", "Мед", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 61.0, "Пшеничное", "Ржаное", "Рыба", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 203.0, "Сырое", "Шоколадное", "Салат", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 119.0, "Жареное", "Сырое", "Кофе", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 226.0, "Сочное", "Кофе", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 147.0, "Медовое", "Молочное", "Овощи", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 13.0, "Натуральное", "Мягкое", "Мед", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 168.0, "Постное", "Молочное", "Хлеб", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 161.0, "Вкусное", "Тушеное", "Сок", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 238.0, "Молочное", "Молочное", "Томаты", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 103.0, "Красивое", "Медовое", "Сыр", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 77.0, "Соленое", "Сладкое", "Огурцы", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 3, 24.0, "Пшеничное", "Рыбное", "Пирог" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 183.0, "Пикантное", "Рыбное", "Гречка", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 206.0, "Молочное", "Твердое", "Торт", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 14, 115.0, "Ванильное", "Кекс", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 68.0, "Красивое", "Пряное", "Яйца", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 5, 22.0, "Соленое", "Пельмени", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 173.0, "Морское", "Ванильное", "Кола", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 29.0, "Рыбное", "Овощное", "Сгущенка", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 102.0, "Сырое", "Пшеничное", "Сахар", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 15, 154.0, "Мясное", "Салат", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 94.0, "Сытное", "Свежее", "Хлеб", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 187.0, "Сырое", "Ванильное", "Мороженное", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 39.0, "Постное", "Запеченное", "Макароны", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 231.0, "Полезное", "Чай", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 78.0, "Ароматное", "Сырое", "Сгущенка", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 57.0, "Полезное", "Вкусное", "Пицца", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 143.0, "Жидкое", "Пикантное", "Перец", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 146.0, "Острое", "Натуральное", "Овощи", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 189.0, "Острое", "Ванильное", "Кола", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 40.0, "Питательное", "Сладкое", "Огурцы", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 85.0, "Полезное", "Шоколадное", "Гречка", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 194.0, "Пряное", "Сочное", "Мороженное", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 159.0, "Ароматное", "Сочное", "Паста", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 207.0, "Сырое", "Медовое", "Овощи", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 11.0, "Питательное", "Пшеничное", "Тушенка", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 93.0, "Сочное", "Морское", "Каша", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 39.0, "Ржаное", "Сытное", "Каша", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 156.0, "Сочное", "Ванильное", "Майонез", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 30.0, "Тушеное", "Шоколадное", "Каша", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 243.0, "Сладкое", "Постное", "Кекс", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 37.0, "Свежевыжатое", "Мягкое", "Кофе", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 12.0, "Медовое", "Вареное", "Томаты", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 200.0, "Сладкое", "Рыбное", "Торт", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 73.0, "Твердое", "Медовое", "Морковь", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 63.0, "Молочное", "Свежевыжатое", "Морковь", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 73.0, "Пшеничное", "Ванильное", "Квас", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 127.0, "Сытное", "Сладкое", "Торт", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 127.0, "Сочное", "Жареное", "Кетчуп", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 206.0, "Сытное", "Питательное", "Печенье", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 108.0, "Ржаное", "Жареное", "Салат", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 167.0, "Нежное", "Острое", "Салат", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 21.0, "Вкусное", "Морское", "Картофель", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 193.0, "Сырое", "Постное", "Кекс", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 144.0, "Красивое", "Свежее", "Морковь", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 8.0, "Пшеничное", "Фруктовое", "Пельмени", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 31.0, "Сладкое", "Шоколадное", "Красное вино", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 8, 144.0, "Морское", "Ржаное", "Мед" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 218.0, "Пикантное", "Сырое", "Красное вино", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 248.0, "Пикантное", "Морское", "Кекс", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 8.0, "Твердое", "Тушеное", "Морковь", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 244.0, "Приправленное", "Натуральное", "Кола", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 139.0, "Пшеничное", "Морское", "Сок", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 82.0, "Молочное", "Вареное", "Печенье", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 145.0, "Свежевыжатое", "Молочное", "Рис", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 190.0, "Свежевыжатое", "Сладкое", "Хлеб", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 246.0, "Пряное", "Рыбное", "Овощи", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 218.0, "Жареное", "Красивое", "Фрукты", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 193.0, "Овощное", "Вареное", "Орехи", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 91.0, "Свежевыжатое", "Медовое", "Овощи", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 155.0, "Медовое", "Сырое", "Гречка", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 188.0, "Натуральное", "Рыбное", "Гречка", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 48.0, "Молочное", "Фруктовое", "Морепродукты", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 48.0, "Мясное", "Сочное", "Тушенка", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 14, 230.0, "Рыбное", "Квас", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 9, 122.0, "Сладкое", "Печенье", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 15, 56.0, "Сочное", "Фрукты", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 21.0, "Сладкое", "Жидкое", "Каша", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 107.0, "Сытное", "Сырое", "Перец", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 59.0, "Мясное", "Нежное", "Перец", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 164.0, "Сладкое", "Сочное", "Торт", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 30.0, "Твердое", "Натуральное", "Сгущенка", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 63.0, "Вареное", "Пшеничное", "Макароны", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 211.0, "Пряное", "Молочное", "Шоколад", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 175.0, "Молочное", "Майонез", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 126.0, "Овощное", "Мягкое", "Шоколад", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 21.0, "Пряное", "Красивое", "Гречка", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 78.0, "Сырое", "Запеченное", "Кофе", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 167.0, "Овощное", "Приправленное", "Яйца", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 232.0, "Жидкое", "Сочное", "Овощи", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 237.0, "Полезное", "Полезное", "Вода", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 151.0, "Шоколадное", "Соленое", "Кофе", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 197.0, "Ароматное", "Твердое", "Майонез", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 126.0, "Соленое", "Молочное", "Вода", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 13, 164.0, "Натуральное", "Сытное", "Красное вино" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 17, 205.0, "Овощное", "Чай", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 139.0, "Свежевыжатое", "Твердое", "Квас", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 38.0, "Свежевыжатое", "Красное вино", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 219.0, "Ароматное", "Натуральное", "Рыба", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 177.0, "Пшеничное", "Морское", "Вода", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 243.0, "Овощное", "Жидкое", "Огурцы", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 68.0, "Ржаное", "Острое", "Сыр", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 89.0, "Сладкое", "Рыбное", "Кофе", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 39.0, "Пшеничное", "Сытное", "Мороженное", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 8, 67.0, "Ароматное", "Жареное", "Перец" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 162.0, "Свежевыжатое", "Пикантное", "Молоко", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 195.0, "Сладкое", "Соленое", "Маргарин", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 223.0, "Шоколадное", "Жидкое", "Мясо", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 240.0, "Медовое", "Натуральное", "Кола", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 219.0, "Пикантное", "Ржаное", "Тушенка", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 184.0, "Свежевыжатое", "Полезное", "Сыр", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 181.0, "Соленое", "Нежное", "Белое вино", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 3.0, "Сочное", "Мясное", "Кола", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 59.0, "Ржаное", "Сладкое", "Печенье", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 235.0, "Твердое", "Натуральное", "Орехи", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 166.0, "Вареное", "Вкусное", "Паста", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 181.0, "Шоколадное", "Тушеное", "Рис", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 77.0, "Приправленное", "Запеченное", "Морковь", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 135.0, "Жидкое", "Пикантное", "Салат", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 17, 118.0, "Медовое", "Тушеное", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 42.0, "Молочное", "Пикантное", "Вода", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 10, 156.0, "Вареное", "Ванильное", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 54.0, "Полезное", "Жареное", "Соус", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 76.0, "Вареное", "Молочное", "Кетчуп", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 164.0, "Тушеное", "Сладкое", "Курица", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 77.0, "Питательное", "Свежее", "Сгущенка", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 11, 79.0, "Рыбное", "Сок", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 210.0, "Жидкое", "Сладкое", "Сок", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 112.0, "Полезное", "Красивое", "Кекс", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 210.0, "Вкусное", "Соленое", "Орехи", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 203.0, "Вареное", "Вкусное", "Пирог", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 36.0, "Вкусное", "Мягкое", "Белое вино", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 201.0, "Полезное", "Пшеничное", "Перец", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 215.0, "Постное", "Сытное", "Перец", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 124.0, "Сочное", "Жареное", "Сахар", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 245.0, "Соленое", "Сырое", "Кетчуп", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 56.0, "Ароматное", "Свежее", "Белое вино", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 61.0, "Острое", "Свежее", "Красное вино", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 66.0, "Пшеничное", "Острое", "Мясо", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 111.0, "Свежевыжатое", "Твердое", "Красное вино", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 133.0, "Острое", "Овощное", "Пирог", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 107.0, "Твердое", "Сладкое", "Торт", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 84.0, "Сладкое", "Питательное", "Рыба", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 232.0, "Питательное", "Мягкое", "Морепродукты", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 76.0, "Соленое", "Сладкое", "Тушенка", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 231.0, "Сладкое", "Рыбное", "Кекс", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 235.0, "Твердое", "Вареное", "Кофе", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 77.0, "Медовое", "Свежевыжатое", "Мороженное", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 24.0, "Постное", "Рыбное", "Мясо", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 155.0, "Нежное", "Пирог", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 14.0, "Ванильное", "Фруктовое", "Кетчуп", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 241.0, "Сочное", "Острое", "Мороженное", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 8, 83.0, "Приправленное", "Соль", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 246.0, "Шоколадное", "Сытное", "Курица", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 133.0, "Медовое", "Твердое", "Яйца", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 28.0, "Жареное", "Острое", "Томаты", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 111.0, "Мягкое", "Ванильное", "Каша", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 90.0, "Питательное", "Приправленное", "Каша", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 98.0, "Красивое", "Натуральное", "Курица", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 212.0, "Сочное", "Шоколадное", "Фрукты", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 134.0, "Тушеное", "Овощное", "Огурцы", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 8, 168.0, "Шоколадное", "Пикантное", "Молоко" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 13.0, "Овощное", "Натуральное", "Соус", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 53.0, "Полезное", "Питательное", "Макароны", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 249.0, "Вареное", "Красивое", "Белое вино", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 218.0, "Острое", "Натуральное", "Тушенка", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 238.0, "Сочное", "Мясное", "Огурцы", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 15, 246.0, "Пшеничное", "Мясное", "Овощи" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 3.0, "Жареное", "Вкусное", "Курица", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 53.0, "Шоколадное", "Молочное", "Сок", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 177.0, "Сочное", "Шоколадное", "Кетчуп", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 29.0, "Свежее", "Вареное", "Фрукты", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 180.0, "Шоколадное", "Соленое", "Молоко", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 245.0, "Сытное", "Вареное", "Огурцы", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 133.0, "Постное", "Соленое", "Майонез", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 32.0, "Острое", "Сытное", "Шоколад", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 50.0, "Жареное", "Фрукты", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 108.0, "Запеченное", "Фруктовое", "Квас", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 184.0, "Сочное", "Тушеное", "Морепродукты", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 83.0, "Ванильное", "Питательное", "Кола", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 52.0, "Натуральное", "Ванильное", "Хлеб", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 216.0, "Пшеничное", "Постное", "Квас", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 114.0, "Пшеничное", "Жареное", "Курица", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 226.0, "Жидкое", "Пряное", "Печенье", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 181.0, "Пшеничное", "Медовое", "Перец", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 247.0, "Соленое", "Жидкое", "Гречка", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 19.0, "Вареное", "Фруктовое", "Белое вино", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 156.0, "Вкусное", "Острое", "Кофе", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 111.0, "Нежное", "Свежее", "Огурцы", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 170.0, "Медовое", "Питательное", "Фрукты", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 174.0, "Ванильное", "Морское", "Мясо", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 64.0, "Запеченное", "Ржаное", "Кекс", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 130.0, "Свежее", "Тушеное", "Перец", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 246.0, "Ванильное", "Запеченное", "Чай", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 233.0, "Тушеное", "Запеченное", "Перец", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 98.0, "Ржаное", "Натуральное", "Сгущенка", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 107.0, "Шоколадное", "Приправленное", "Яйца", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 71.0, "Вкусное", "Вкусное", "Соль", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 229.0, "Медовое", "Свежевыжатое", "Кекс", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 9.0, "Сочное", "Ванильное", "Сгущенка", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 15, 131.0, "Ржаное", "Жидкое", "Сахар" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 140.0, "Мягкое", "Мясное", "Гречка", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 79.0, "Медовое", "Натуральное", "Рыба", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 140.0, "Приправленное", "Шоколадное", "Яйца", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 5, 184.0, "Вареное", "Медовое", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 192.0, "Вкусное", "Ванильное", "Чай", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 146.0, "Пряное", "Молочное", "Сгущенка", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 213.0, "Мясное", "Сладкое", "Каша", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 234.0, "Сочное", "Сырое", "Кофе", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 113.0, "Медовое", "Мягкое", "Рыба", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 245.0, "Твердое", "Питательное", "Сыр", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 221.0, "Свежее", "Тушеное", "Макароны", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 130.0, "Ароматное", "Сырое", "Сок", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 162.0, "Молочное", "Твердое", "Морепродукты", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 5, 248.0, "Мясное", "Питательное", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 238.0, "Мясное", "Шоколадное", "Курица", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 96.0, "Шоколадное", "Рыбное", "Пельмени", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 36.0, "Сочное", "Соленое", "Томаты", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 234.0, "Приправленное", "Свежевыжатое", "Мед", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 221.0, "Полезное", "Соленое", "Майонез", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 234.0, "Запеченное", "Свежее", "Орехи", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 206.0, "Морское", "Питательное", "Сахар", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "SpecialNote" },
                values: new object[] { 10, 120.0, "Питательное", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 237.0, "Свежее", "Ванильное", "Фрукты", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 194.0, "Полезное", "Жареное", "Пельмени", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 28.0, "Тушеное", "Овощное", "Белое вино", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 142.0, "Питательное", "Сладкое", "Каша", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 155.0, "Запеченное", "Молочное", "Картофель", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 27.0, "Пряное", "Жареное", "Кекс", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 58.0, "Вкусное", "Жидкое", "Соль", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 145.0, "Красивое", "Мягкое", "Макароны", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 45.0, "Натуральное", "Мягкое", "Рыба", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 142.0, "Ржаное", "Ванильное", "Мясо", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 206.0, "Красивое", "Фруктовое", "Кола", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 94.0, "Сырое", "Рыбное", "Мороженное", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 96.0, "Ржаное", "Сытное", "Торт", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 127.0, "Постное", "Сладкое", "Макароны", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 94.0, "Соленое", "Тушеное", "Квас", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 80.0, "Сытное", "Медовое", "Овощи", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 67.0, "Жидкое", "Ванильное", "Хлеб", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 14, 189.0, "Вареное", "Морское", "Рыба" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 104.0, "Мягкое", "Вкусное", "Овощи", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 177.0, "Мясное", "Сырое", "Маргарин", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 76.0, "Вареное", "Ржаное", "Мороженное", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 60.0, "Питательное", "Сочное", "Паста", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 15, 2.0, "Молочное", "Ароматное", "Каша" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 235.0, "Сладкое", "Ванильное", "Соус", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 163.0, "Острое", "Шоколадное", "Морковь", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 242.0, "Соленое", "Сочное", "Курица", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 79.0, "Пшеничное", "Орехи", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 90.0, "Пшеничное", "Рыбное", "Огурцы", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 15.0, "Фруктовое", "Мясное", "Мороженное", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 93.0, "Вкусное", "Запеченное", "Чай", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 223.0, "Острое", "Шоколадное", "Тушенка", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote" },
                values: new object[] { 10, 14.0, "Сладкое", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 99.0, "Тушеное", "Мягкое", "Орехи", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 49.0, "Ароматное", "Мягкое", "Мед", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 172.0, "Ароматное", "Полезное", "Мороженное", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 2, 45.0, "Ржаное", "Сочное", "Кекс" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 17.0, "Сладкое", "Медовое", "Курица", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 6, 162.0, "Молочное", "Медовое", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 20.0, "Нежное", "Морское", "Томаты", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 84.0, "Пшеничное", "Натуральное", "Чай", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 202.0, "Жидкое", "Пикантное", "Сахар", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 181.0, "Свежее", "Фруктовое", "Фрукты", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 68.0, "Соленое", "Натуральное", "Тушенка", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 239.0, "Свежевыжатое", "Ржаное", "Рис", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 52.0, "Шоколадное", "Постное", "Молоко", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 5, 191.0, "Жареное", "Твердое", "Сгущенка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 171.0, "Морское", "Вареное", "Курица", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 64.0, "Твердое", "Овощное", "Кекс", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 217.0, "Морское", "Питательное", "Пельмени", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 108.0, "Свежее", "Мягкое", "Орехи", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 1, 190.0, "Фруктовое", "Сырое", "Пицца" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 93.0, "Пикантное", "Ванильное", "Мясо", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 19.0, "Морское", "Красивое", "Соус", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 146.0, "Тушеное", "Соленое", "Торт", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 88.0, "Рыбное", "Жидкое", "Томаты", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 151.0, "Соленое", "Соленое", "Яйца", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 36.0, "Свежевыжатое", "Ароматное", "Мед", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 117.0, "Ванильное", "Красивое", "Сок", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 30.0, "Фруктовое", "Пряное", "Сгущенка", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 36.0, "Сырое", "Свежевыжатое", "Кола", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 112.0, "Сырое", "Пряное", "Хлеб", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 235.0, "Медовое", "Вкусное", "Орехи", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 26.0, "Соленое", "Мясное", "Сгущенка", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 126.0, "Сочное", "Полезное", "Пельмени", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 84.0, "Овощное", "Сочное", "Пирог", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 89.0, "Овощное", "Жидкое", "Курица", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 38.0, "Морское", "Свежее", "Сгущенка", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 185.0, "Жидкое", "Рыбное", "Чай", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 248.0, "Сырое", "Жареное", "Кола", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 229.0, "Красивое", "Соус", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 20.0, "Жидкое", "Полезное", "Квас", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 60.0, "Вкусное", "Твердое", "Пельмени", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 114.0, "Сочное", "Сладкое", "Шоколад", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 121.0, "Твердое", "Чай", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 11.0, "Пикантное", "Мясное", "Курица", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 26.0, "Мягкое", "Тушеное", "Сгущенка", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 150.0, "Сытное", "Тушеное", "Пирог", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 182.0, "Сырое", "Фруктовое", "Сгущенка", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 3.0, "Питательное", "Кола", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 31.0, "Жидкое", "Нежное", "Тушенка", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 7, 59.0, "Ржаное", "Свежее", "Картофель" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 101.0, "Свежевыжатое", "Свежее", "Салат", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 43.0, "Твердое", "Постное", "Соус", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 187.0, "Твердое", "Молочное", "Майонез", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 31.0, "Твердое", "Огурцы", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 143.0, "Полезное", "Сырое", "Маргарин", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 147.0, "Пряное", "Фруктовое", "Салат", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 173.0, "Ржаное", "Нежное", "Сахар", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 173.0, "Твердое", "Морское", "Огурцы", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 119.0, "Свежевыжатое", "Жареное", "Пельмени", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 160.0, "Мягкое", "Твердое", "Белое вино", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 120.0, "Свежевыжатое", "Пикантное", "Печенье", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 215.0, "Тушеное", "Пикантное", "Курица", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 44.0, "Свежее", "Вареное", "Маргарин", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 168.0, "Нежное", "Шоколадное", "Морковь", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 176.0, "Свежевыжатое", "Ванильное", "Морепродукты", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 213.0, "Сочное", "Сырое", "Соль", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 134.0, "Ржаное", "Приправленное", "Соль", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 175.0, "Ванильное", "Сочное", "Маргарин", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 38.0, "Сырое", "Жареное", "Мороженное", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 10, 176.0, "Соленое", "Кекс", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 225.0, "Приправленное", "Натуральное", "Торт", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 205.0, "Сытное", "Полезное", "Белое вино", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 132.0, "Полезное", "Сырое", "Сахар", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 160.0, "Ароматное", "Пикантное", "Рыба", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 81.0, "Красивое", "Сладкое", "Маргарин", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 165.0, "Полезное", "Вареное", "Сок", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 213.0, "Ржаное", "Фруктовое", "Соус", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 182.0, "Ароматное", "Свежевыжатое", "Пицца", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 62.0, "Соленое", "Жареное", "Белое вино", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 141.0, "Запеченное", "Тушеное", "Молоко", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 161.0, "Натуральное", "Овощное", "Кекс", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 151.0, "Свежевыжатое", "Медовое", "Тушенка", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 180.0, "Вкусное", "Острое", "Томаты", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 245.0, "Натуральное", "Фруктовое", "Соус", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 166.0, "Острое", "Пряное", "Соус", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 155.0, "Запеченное", "Мягкое", "Овощи", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 240.0, "Тушеное", "Ржаное", "Хлеб", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 123.0, "Мягкое", "Рыбное", "Красное вино", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 52.0, "Вареное", "Натуральное", "Яйца", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote" },
                values: new object[] { 7, 150.0, "Запеченное", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 53.0, "Мягкое", "Нежное", "Гречка", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 73.0, "Ржаное", "Молоко", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 126.0, "Фруктовое", "Вкусное", "Курица", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 195.0, "Нежное", "Запеченное", "Рыба", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 228.0, "Острое", "Овощное", "Мед", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 160.0, "Жареное", "Питательное", "Торт", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 97.0, "Мягкое", "Морское", "Овощи", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "SpecialNote" },
                values: new object[] { 12, 14.0, "Ржаное", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 11.0, "Соленое", "Пикантное", "Морепродукты", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 190.0, "Сладкое", "Ароматное", "Огурцы", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 163.0, "Мягкое", "Тушеное", "Вода", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 102.0, "Вкусное", "Пряное", "Каша", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 2.0, "Рыбное", "Пряное", "Рыба", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 216.0, "Запеченное", "Сладкое", "Красное вино", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 109.0, "Жидкое", "Рыбное", "Макароны", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 145.0, "Натуральное", "Сочное", "Маргарин", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 60.0, "Питательное", "Пикантное", "Кола", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 122.0, "Шоколадное", "Сырое", "Гречка", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 222.0, "Морское", "Сладкое", "Мясо", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 10.0, "Пикантное", "Свежее", "Торт", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 2.0, "Сладкое", "Рыбное", "Соус", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 218.0, "Тушеное", "Вкусное", "Паста", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 65.0, "Рыбное", "Молочное", "Морковь", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 138.0, "Пряное", "Постное", "Соль", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 230.0, "Тушеное", "Питательное", "Печенье", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 227.0, "Свежее", "Ароматное", "Красное вино", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 30.0, "Ржаное", "Шоколадное", "Яйца", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 163.0, "Мягкое", "Сырое", "Яйца", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 46.0, "Фруктовое", "Свежее", "Рыба", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 129.0, "Морское", "Пшеничное", "Морепродукты", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 233.0, "Пшеничное", "Жидкое", "Вода", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 214.0, "Питательное", "Тушеное", "Кекс", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 227.0, "Ржаное", "Сырое", "Перец", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 171.0, "Рыбное", "Ароматное", "Кетчуп", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 249.0, "Мягкое", "Жидкое", "Пицца", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 51.0, "Ванильное", "Пряное", "Соль", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 81.0, "Овощное", "Сладкое", "Перец", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 181.0, "Сладкое", "Жареное", "Красное вино", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 228.0, "Твердое", "Запеченное", "Мясо", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 122.0, "Нежное", "Вареное", "Кофе", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 93.0, "Запеченное", "Питательное", "Сгущенка", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 179.0, "Жареное", "Острое", "Соль", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 104.0, "Свежее", "Нежное", "Гречка", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 167.0, "Вкусное", "Питательное", "Томаты", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 9.0, "Питательное", "Фруктовое", "Рыба", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 224.0, "Ржаное", "Ароматное", "Тушенка", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 77.0, "Сладкое", "Жидкое", "Сок", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 12.0, "Соленое", "Сочное", "Белое вино", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 208.0, "Мясное", "Сытное", "Паста", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 18.0, "Сладкое", "Сочное", "Соус", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 19.0, "Жидкое", "Морское", "Каша", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 47.0, "Сырое", "Сочное", "Вода", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 144.0, "Нежное", "Запеченное", "Салат", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 131.0, "Свежее", "Ароматное", "Сгущенка", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 243.0, "Сырое", "Овощное", "Майонез", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 123.0, "Пшеничное", "Сытное", "Овощи", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 52.0, "Питательное", "Питательное", "Орехи", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 135.0, "Тушеное", "Пшеничное", "Кекс", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 239.0, "Сырое", "Приправленное", "Перец", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 103.0, "Полезное", "Красивое", "Шоколад", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 89.0, "Фруктовое", "Жидкое", "Гречка", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 185.0, "Ароматное", "Жидкое", "Рис", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 225.0, "Сладкое", "Сырое", "Пицца", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 5.0, "Острое", "Тушенка", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 114.0, "Запеченное", "Ржаное", "Макароны", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 35.0, "Питательное", "Вареное", "Чай", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 231.0, "Овощное", "Пшеничное", "Фрукты", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 95.0, "Постное", "Вкусное", "Салат", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 59.0, "Пикантное", "Острое", "Пельмени", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 154.0, "Мясное", "Молочное", "Сгущенка", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 33.0, "Мясное", "Яйца", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 6, 112.0, "Пшеничное", "Натуральное", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 100.0, "Приправленное", "Фруктовое", "Сок", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 144.0, "Мясное", "Приправленное", "Мороженное", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 210.0, "Мясное", "Сытное", "Кола", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 72.0, "Тушеное", "Сладкое", "Мороженное", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 56.0, "Полезное", "Соленое", "Каша", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 39.0, "Ароматное", "Жидкое", "Картофель", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 18, 143.0, "Соленое", "Соленое", "Орехи" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 108.0, "Морское", "Сочное", "Хлеб", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 13, 17.0, "Сытное", "Картофель", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 243.0, "Фруктовое", "Ароматное", "Орехи", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 237.0, "Рыбное", "Пшеничное", "Овощи", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 110.0, "Сочное", "Шоколадное", "Орехи", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 149.0, "Сладкое", "Полезное", "Сыр", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 185.0, "Приправленное", "Тушеное", "Мороженное", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 11, 147.0, "Сладкое", "Натуральное", "Сок" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 115.0, "Свежее", "Острое", "Торт", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 23.0, "Запеченное", "Вареное", "Макароны", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 56.0, "Морское", "Ванильное", "Сгущенка", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 65.0, "Приправленное", "Свежевыжатое", "Паста", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 9.0, "Жареное", "Сытное", "Морепродукты", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 64.0, "Острое", "Молочное", "Овощи", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 98.0, "Красивое", "Тушеное", "Яйца", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 175.0, "Ржаное", "Пикантное", "Соль", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 145.0, "Пшеничное", "Сладкое", "Мед", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 136.0, "Красивое", "Тушеное", "Морковь", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 57.0, "Шоколадное", "Тушеное", "Сгущенка", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 154.0, "Сочное", "Ржаное", "Торт", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 145.0, "Красивое", "Свежевыжатое", "Курица", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 66.0, "Свежее", "Свежевыжатое", "Сыр", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 75.0, "Острое", "Морское", "Торт", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 53.0, "Жареное", "Тушеное", "Салат", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 167.0, "Сытное", "Сладкое", "Квас", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 14.0, "Сырое", "Сырое", "Томаты", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 87.0, "Ржаное", "Вареное", "Молоко", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 48.0, "Сладкое", "Соленое", "Кекс", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 94.0, "Ванильное", "Жидкое", "Хлеб", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 30.0, "Питательное", "Ароматное", "Кофе", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 50.0, "Мягкое", "Постное", "Томаты", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 26.0, "Тушеное", "Сладкое", "Каша", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 54.0, "Тушеное", "Постное", "Молоко", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 59.0, "Сытное", "Вареное", "Салат", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 217.0, "Питательное", "Пшеничное", "Печенье", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 74.0, "Питательное", "Красивое", "Хлеб", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 79.0, "Свежевыжатое", "Кофе", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 68.0, "Жидкое", "Постное", "Кекс", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 100.0, "Сладкое", "Пряное", "Макароны", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 171.0, "Пшеничное", "Рыбное", "Соус", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 48.0, "Пряное", "Мягкое", "Квас", "Красивое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 11.0, "Питательное", "Ванильное", "Макароны", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 117.0, "Пряное", "Мясное", "Тушенка", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 74.0, "Запеченное", "Мягкое", "Сахар", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 34.0, "Сочное", "Тушеное", "Маргарин", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 175.0, "Вкусное", "Рыбное", "Каша", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 99.0, "Шоколадное", "Мясное", "Макароны", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 14.0, "Жареное", "Сытное", "Кофе", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 64.0, "Рыбное", "Пряное", "Морковь", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 76.0, "Пикантное", "Рыбное", "Чай", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 13.0, "Ванильное", "Свежее", "Молоко", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 174.0, "Вкусное", "Соленое", "Молоко", "Острое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 151.0, "Шоколадное", "Приправленное", "Пирог", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 129.0, "Пряное", "Вкусное", "Тушенка", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 196.0, "Овощное", "Сырое", "Кетчуп", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 39.0, "Мясное", "Полезное", "Картофель", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 209.0, "Рыбное", "Рыбное", "Курица", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 108.0, "Постное", "Сладкое", "Вода", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 234.0, "Пшеничное", "Морское", "Белое вино", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 146.0, "Сладкое", "Пряное", "Сгущенка", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 2, 132.0, "Ванильное", "Пикантное", "Хлеб" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 160.0, "Острое", "Нежное", "Каша", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 5.0, "Ароматное", "Ароматное", "Соус", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 62.0, "Свежее", "Полезное", "Паста", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 4, 131.0, "Рыбное", "Жареное", "Кекс" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 181.0, "Овощное", "Натуральное", "Тушенка", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 31.0, "Ванильное", "Жидкое", "Гречка", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 34.0, "Вкусное", "Запеченное", "Овощи", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 249.0, "Сладкое", "Пряное", "Пельмени", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 7.0, "Полезное", "Соленое", "Пицца", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 110.0, "Свежее", "Вареное", "Орехи", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 94.0, "Вареное", "Приправленное", "Соус", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 149.0, "Рыбное", "Сытное", "Яйца", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 136.0, "Вкусное", "Медовое", "Огурцы", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 231.0, "Соленое", "Овощное", "Вода", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 129.0, "Запеченное", "Ржаное", "Чай", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 192.0, "Красивое", "Мясное", "Рыба", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 110.0, "Молочное", "Фруктовое", "Морепродукты", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 76.0, "Красивое", "Фруктовое", "Перец", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 223.0, "Молочное", "Ванильное", "Орехи", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 139.0, "Ржаное", "Сырое", "Морепродукты", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 6, 133.0, "Приправленное", "Шоколад", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "CategoryId", "Cost", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 94.0, "Красивое", "Рис", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 12, 205.0, "Твердое", "Сырое", "Маргарин", "Соленое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 144.0, "Сочное", "Шоколадное", "Тушенка", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 63.0, "Красивое", "Пшеничное", "Перец", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 63.0, "Морское", "Свежевыжатое", "Огурцы", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 8, 122.0, "Мягкое", "Тушеное", "Вода" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 39.0, "Пикантное", "Питательное", "Перец", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 8, 201.0, "Соленое", "Мясное", "Фрукты" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 32.0, "Рыбное", "Курица", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 122.0, "Сочное", "Рыбное", "Соль", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 247.0, "Свежее", "Мясное", "Тушенка", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 207.0, "Вареное", "Рыбное", "Сахар", "Ароматное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 4.0, "Сладкое", "Питательное", "Мед", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 219.0, "Ржаное", "Твердое", "Гречка", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 93.0, "Сочное", "Тушеное", "Вода", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 110.0, "Морское", "Запеченное", "Кекс", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 73.0, "Морское", "Острое", "Овощи", "Жареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 74.0, "Натуральное", "Жидкое", "Торт", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 69.0, "Медовое", "Сочное", "Мороженное", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 128.0, "Ванильное", "Питательное", "Мед", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 80.0, "Постное", "Постное", "Кофе", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 238.0, "Пшеничное", "Тушеное", "Паста", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 193.0, "Свежее", "Питательное", "Торт", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 111.0, "Вареное", "Сырое", "Кекс", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 148.0, "Питательное", "Пшеничное", "Вода", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 125.0, "Пшеничное", "Питательное", "Тушенка", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 247.0, "Шоколадное", "Жареное", "Гречка", "Морское" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 213.0, "Ароматное", "Фруктовое", "Кофе", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 62.0, "Вкусное", "Жареное", "Соль", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 10.0, "Постное", "Сытное", "Кола", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 249.0, "Запеченное", "Сырое", "Кекс", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 23.0, "Пшеничное", "Медовое", "Хлеб", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 160.0, "Ароматное", "Вареное", "Шоколад", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 213.0, "Шоколадное", "Пикантное", "Пицца", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 74.0, "Вареное", "Питательное", "Сыр", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 225.0, "Сладкое", "Ванильное", "Квас", "Медовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 142.0, "Пшеничное", "Ароматное", "Мороженное", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 38.0, "Морское", "Сладкое", "Печенье", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 57.0, "Питательное", "Вареное", "Квас", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 120.0, "Мясное", "Пряное", "Перец", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 39.0, "Жидкое", "Сочное", "Сок", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 203.0, "Мясное", "Сладкое", "Пирог", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 102.0, "Пикантное", "Сытное", "Пицца", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 78.0, "Мягкое", "Фруктовое", "Макароны", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 154.0, "Медовое", "Сладкое", "Фрукты", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 154.0, "Жидкое", "Пряное", "Пицца", "Сырое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 150.0, "Постное", "Молочное", "Мясо", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 65.0, "Медовое", "Постное", "Майонез", "Шоколадное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 173.0, "Вкусное", "Соленое", "Томаты", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 12, 246.0, "Приправленное", "Картофель", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 61.0, "Сытное", "Свежее", "Майонез", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 125.0, "Шоколадное", "Рыбное", "Сыр", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 20.0, "Медовое", "Пикантное", "Томаты", "Натуральное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 67.0, "Сытное", "Острое", "Пирог", "Свежее" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 22.0, "Молочное", "Питательное", "Квас", "Нежное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 33.0, "Постное", "Постное", "Хлеб", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 46.0, "Свежее", "Пикантное", "Паста", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 27.0, "Ванильное", "Фруктовое", "Сыр", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 44.0, "Морское", "Красивое", "Мясо", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 217.0, "Пряное", "Рыбное", "Сок", "Ванильное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 244.0, "Свежевыжатое", "Приправленное", "Мед", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 2, 126.0, "Тушеное", "Приправленное", "Гречка", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name" },
                values: new object[] { 15, 178.0, "Ржаное", "Вареное", "Белое вино" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 249.0, "Сытное", "Ржаное", "Кетчуп", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 127.0, "Ванильное", "Полезное", "Майонез", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 4, 131.0, "Вкусное", "Питательное", "Квас", "Фруктовое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 7, 114.0, "Мягкое", "Шоколадное", "Сок", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote" },
                values: new object[] { 14, 59.0, "Тушеное", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 121.0, "Сытное", "Соленое", "Яйца", "Жидкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 120.0, "Мягкое", "Свежевыжатое", "Пицца", "Свежевыжатое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 8, 132.0, "Пшеничное", "Острое", "Кетчуп", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "SpecialNote" },
                values: new object[] { 16, 21.0, "Пряное", "Сытное", "Молочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 33.0, "Молочное", "Ржаное", "Мясо", "Вкусное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 233.0, "Жареное", "Соленое", "Вода", "Ржаное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 71.0, "Соленое", "Овощное", "Маргарин", "Полезное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 117.0, "Пшеничное", "Пшеничное", "Хлеб", "Сладкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 77.0, "Рыбное", "Соленое", "Курица", "Тушеное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 17, 125.0, "Сырое", "Жидкое", "Мед", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 14, 189.0, "Соленое", "Тушеное", "Паста", "Вареное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "CategoryId", "Cost", "Description", "Name", "SpecialNote" },
                values: new object[] { 6, 47.0, "Медовое", "Пицца", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 83.0, "Тушеное", "Рыбное", "Мед", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 239.0, "Постное", "Вкусное", "Овощи", "Пшеничное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 151.0, "Шоколадное", "Пшеничное", "Квас", "Пряное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 161.0, "Овощное", "Вареное", "Торт", "Рыбное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 18, 171.0, "Ванильное", "Рыбное", "Соль", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 225.0, "Ванильное", "Ванильное", "Рис", "Сытное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 236.0, "Фруктовое", "Шоколадное", "Томаты", "Питательное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 170.0, "Сочное", "Острое", "Сахар", "Пикантное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 11, 216.0, "Постное", "Сытное", "Орехи", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 16, 99.0, "Сладкое", "Сочное", "Макароны", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 9, 213.0, "Сырое", "Морское", "Сгущенка", "Сочное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 1, 72.0, "Питательное", "Овощное", "Сгущенка", "Твердое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 199.0, "Рыбное", "Морское", "Томаты", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 6, 64.0, "Мясное", "Сырое", "Пирог", "Приправленное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 85.0, "Полезное", "Мясное", "Сгущенка", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 3, 27.0, "Вкусное", "Полезное", "Овощи", "Мясное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 10, 61.0, "Вареное", "Пикантное", "Морепродукты", "Запеченное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 184.0, "Медовое", "Вкусное", "Салат", "Мягкое" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 15, 194.0, "Свежевыжатое", "Приправленное", "Соус", "Овощное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 13, 24.0, "Морское", "Молочное", "Кола", "Постное" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "CategoryId", "Cost", "Description", "GeneralNote", "Name", "SpecialNote" },
                values: new object[] { 5, 103.0, "Питательное", "Сырое", "Соль", "Мягкое" });
        }
    }
}
