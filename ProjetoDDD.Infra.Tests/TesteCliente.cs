using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoModeloDDD.Infra.Data.Repositories;
using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;

namespace ProjetoDDD.Infra.Tests
{
    [TestClass]
    public class TesteCliente
    {
        [TestMethod]
        public void GetAll()
        {
            ClienteRepository repository = new ClienteRepository();
            IEnumerable<Cliente> Clientes = repository.GetAll();
            Assert.IsTrue(Clientes != null);
        }
    }
}
