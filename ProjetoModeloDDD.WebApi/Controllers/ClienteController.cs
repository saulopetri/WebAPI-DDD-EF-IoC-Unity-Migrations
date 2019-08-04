using ProjetoModeloDDD.WebApi.ViewModels;
using System.Collections.Generic;
using System.Web.Http;
using ProjetoModeloDDD.Application.Interfaces;
using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using System.Web.Http.Description;
using ProjetoModeloDDD.Application;

namespace ProjetoModeloDDD.WebApi.Controllers
{
    public class ClienteController : ApiController
    {
        public IClienteAppService _clienteApp;

        public ClienteController(IClienteAppService clienteApp)
        {
            _clienteApp = clienteApp;
        }

        [HttpGet]
        [ResponseType(typeof(IEnumerable<ClienteViewModel>))]
        [Route("cliente/getAll")]
        public IEnumerable<ClienteViewModel> GetAll()
        {

            return null;
        }
    }
}
