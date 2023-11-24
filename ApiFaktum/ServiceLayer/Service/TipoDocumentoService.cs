using Commun.Logger;
using DomainLayer.Dtos;
using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;

namespace ServiceLayer.Service
{
    public class TipoDocumentoService : ITipoDocumentoService
    {
        private readonly ICreateLogger _createLogger;
        private readonly ITipoDocumentoRepository _objRepository;

        public TipoDocumentoService(ITipoDocumentoRepository objRepository, ICreateLogger createLogger)
        {
            _objRepository = objRepository;
            _createLogger = createLogger;
        }

        public Task<Result> Delete(TipoDocumentoDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<Result> GetAll()
        {
            return _objRepository.GetAll();
        }

        public Task<Result> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Result> Insert(TipoDocumentoDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<Result> Update(TipoDocumentoDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
