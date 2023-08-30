using AutoMapper;
using ProductCatalog.Data.Interfaces;
using ProductCatalog.Services.Interfaces;

namespace ProductCatalog.Services.Services
{
    public class BaseService : IService
    {
        protected IUnitOfWork _database;
        protected IMapper _mapper;

        public BaseService(IUnitOfWork database, IMapper mapper)
        {
            _database = database;
            _mapper = mapper;
        }
    }
}