using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.WebApi.ViewModels;

namespace ProjetoModeloDDD.WebApi.AutoMapper
{
    public class DomainToViewModel: Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<EnderecoViewModel, Endereco>();
        }
    }
}