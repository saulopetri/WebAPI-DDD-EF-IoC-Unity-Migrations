using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
namespace ProjetoModeloDDD.Domain.Services
{
    public class EnderecoService : ServiceBase<Endereco>, IEnderecoService
    {
        private readonly IEnderecoRepository _EnderecoRepository;

        public EnderecoService(IEnderecoRepository EnderecoRepository)
            : base(EnderecoRepository)
        {
            _EnderecoRepository = EnderecoRepository;
        }
    }
}
