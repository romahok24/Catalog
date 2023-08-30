using AutoMapper;
using ProductCatalog.Data.Interfaces;
using ProductCatalog.Domain.Models;
using ProductCatalog.DTO;
using ProductCatalog.DTO.Infrastructure;
using ProductCatalog.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ProductCatalog.Constants.Constants;

namespace ProductCatalog.Services.Services
{
    public class CategoryService : BaseService, ICategoryService
    {
        public CategoryService(IUnitOfWork database, IMapper mapper) : base(database, mapper) { }

        public async Task<OperationResponse<CategoryDTO>> Create(CategoryDTO dto)
        {
            try
            {
                var model = _mapper.Map<Category>(dto);

                _database.Categories.Create(model);
                await _database.SaveAsync();

                return new OperationResponse<CategoryDTO>(true, SuccessMessages.Created);
            }
            catch (Exception ex)
            {
                return new OperationResponse<CategoryDTO>(false, ErrorMessages.CreateFailed + ex.Message);
            }
        }

        public async Task<OperationResponse<CategoryDTO>> Delete(int id)
        {
            try
            {
                var model = _database.Categories.Get(id);
                if (model == null)
                {
                    return new OperationResponse<CategoryDTO>(false, ErrorMessages.NotFound);
                }

                _database.Categories.Remove(model);
                await _database.SaveAsync();

                return new OperationResponse<CategoryDTO>(true, SuccessMessages.Deleted);
            }
            catch (Exception ex)
            {
                return new OperationResponse<CategoryDTO>(false, ErrorMessages.DeleteFailed + ex.Message);
            }
        }

        public OperationResponse<CategoryDTO> Read(int id)
        {
            var model = _database.Categories.Include(x => x.Id == id, o => o.Products).FirstOrDefault();

            if (model == null)
            {
                return new OperationResponse<CategoryDTO>(false, ErrorMessages.NotFound);
            }

            var dto = _mapper.Map<CategoryDTO>(model);

            return new OperationResponse<CategoryDTO>(true, SuccessMessages.Retrived, dto);
        }

        public OperationResponse<IEnumerable<CategoryDTO>> Read()
        {
            var model = _database.Categories.Get();

            if (model == null)
            {
                return new OperationResponse<IEnumerable<CategoryDTO>>(false, ErrorMessages.NotFound);
            }

            var dtoList = _mapper.Map<IEnumerable<CategoryDTO>>(model);

            return new OperationResponse<IEnumerable<CategoryDTO>>(true, SuccessMessages.Retrived, dtoList);
        }

        public async Task<OperationResponse<CategoryDTO>> Update(CategoryDTO dto)
        {
            try
            {
                var model = _mapper.Map<Category>(dto);

                _database.Categories.Update(model);
                await _database.SaveAsync();

                return new OperationResponse<CategoryDTO>(true, SuccessMessages.Updated);
            }
            catch (Exception ex)
            {
                return new OperationResponse<CategoryDTO>(false, ErrorMessages.UpdateFailed + ex.Message);
            }
        }
    }
}