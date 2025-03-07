using CruddDapperWebApi.Dto;
using CruddDapperWebApi.Models;

namespace CruddDapperWebApi.Services
{
    public interface IUsuarioInterface
    {
        Task<ResponseModel<List<UsuarioListarDto>>> BuscarUsuarios();


    }
}
