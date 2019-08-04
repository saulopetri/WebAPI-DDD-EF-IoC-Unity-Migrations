using ProjetoModeloDDD.WebApi.ViewModels;
using System.Collections.Generic;
using System.Web.Http;
using ProjetoModeloDDD.Application.Interfaces;
using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using System.Web.Http.Description;
using ProjetoModeloDDD.Application;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.WebApi.Controllers
{
    public class ClienteController : ApiController
    {
        public IClienteService _clienteApp;

        public ClienteController(IClienteService clienteApp)
        {
            _clienteApp = clienteApp;
        }

        [HttpGet]
        [ResponseType(typeof(IEnumerable<ClienteViewModel>))]
        [Route("cliente/getAll")]
        public IEnumerable<ClienteViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteApp.GetAll());
        }
    }
}
