using AutoMapper;
using ProductCatalog.Data.Interfaces;
using ProductCatalog.Domain.Models;
using ProductCatalog.DTO;
using ProductCatalog.DTO.DTO;
using ProductCatalog.DTO.Infrastructure;
using ProductCatalog.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static ProductCatalog.Constants.Constants;

namespace ProductCatalog.Services.Services
{
    public class ProductService : BaseService, IProductService
    {
        public ProductService(IUnitOfWork database, IMapper mapper) : base(database, mapper)
        { 
        }

        public async Task<OperationResponse<ProductDTO>> Create(ProductDTO dto)
        {
            try
            {
                var model = _mapper.Map<Product>(dto);

                _database.Products.Create(model);
                await _database.SaveAsync();

                return new OperationResponse<ProductDTO>(true, SuccessMessages.Created);
            }
            catch (Exception ex)
            {
                return new OperationResponse<ProductDTO>(false, ErrorMessages.CreateFailed + ex.Message);
            }
        }

        public async Task<OperationResponse<ProductDTO>> Delete(int id)
        {
            try
            {
                var model = _database.Products.Get(id);

                if (model == null)
                {
                    return new OperationResponse<ProductDTO>(false, ErrorMessages.NotFound);
                }

                _database.Products.Remove(model);
                await _database.SaveAsync();

                return new OperationResponse<ProductDTO>(true, SuccessMessages.Deleted);
            }
            catch (Exception ex)
            {
                return new OperationResponse<ProductDTO>(false, ErrorMessages.DeleteFailed + ex.Message);
            }
        }

        public IEnumerable<ProductDTO> Read(ProductFilterDTO filter)
        {
            var products = _database.Products.Include(x =>
                (string.IsNullOrEmpty(filter.Name) || x.Name.Contains(filter.Name, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(filter.Description) || x.Description.Contains(filter.Description, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(filter.GeneralNote) || x.GeneralNote.Contains(filter.GeneralNote, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(filter.SpecialNote) || x.SpecialNote.Contains(filter.SpecialNote, StringComparison.OrdinalIgnoreCase)) &&
                (filter.PriceFrom == null || x.Cost >= filter.PriceFrom) &&
                (filter.PriceTo == null || x.Cost <= filter.PriceTo) &&
                (filter.CategoryId == null || x.CategoryId == filter.CategoryId),
                o => o.Category);

            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public OperationResponse<ProductDTO> Read(int id)
        {
            var model = _database.Products.Get(id);

            if (model == null)
            {
                return new OperationResponse<ProductDTO>(false, ErrorMessages.NotFound);
            }

            var dto = _mapper.Map<ProductDTO>(model);
            return new OperationResponse<ProductDTO>(true, SuccessMessages.Retrived, dto);
        }

        public OperationResponse<IEnumerable<ProductDTO>> Read()
        {
            var model = _database.Products.Include(x => x.Category);

            if (model == null)
            {
                return new OperationResponse<IEnumerable<ProductDTO>>(false, ErrorMessages.NotFound);
            }

            var dtoList = _mapper.Map<IEnumerable<ProductDTO>>(model);
            return new OperationResponse<IEnumerable<ProductDTO>>(true, SuccessMessages.Retrived, dtoList);
        }

        public async Task<OperationResponse<ProductDTO>> Update(ProductDTO dto)
        {
            try
            {
                var model = _mapper.Map<Product>(dto);

                _database.Products.Update(model);
                await _database.SaveAsync();

                return new OperationResponse<ProductDTO>(true, SuccessMessages.Updated);
            }
            catch (Exception ex)
            {
                return new OperationResponse<ProductDTO>(false, ErrorMessages.UpdateFailed + ex.Message);
            }
        }
    }
}