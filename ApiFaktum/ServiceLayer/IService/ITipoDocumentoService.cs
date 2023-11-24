using DomainLayer.Dtos;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.IService
{
    public interface ITipoDocumentoService
    {
        Task<Result> GetAll();
        Task<Result> GetById(int Id);
        Task<Result> Insert(TipoDocumentoDto entity);
        Task<Result> Update(TipoDocumentoDto entity);
        Task<Result> Delete(TipoDocumentoDto entity);
    }
}
