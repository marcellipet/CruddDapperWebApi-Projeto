using CruddDapperWebApi.Dto;
using CruddDapperWebApi.Models;

namespace CruddDapperWebApi.Services
{
    public class UsuarioService : IUsuarioInterface
    {
        private readonly IConfiguration _configuration;
        public UsuarioService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<ResponseModel<List<UsuarioListarDto>>> BuscarUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}
