using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.WebApi.ViewModels;

namespace ProjetoModeloDDD.WebApi.AutoMapper
{
    public class ViewModelToDomain : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Endereco, EnderecoViewModel>();
        }
    }
}