﻿using ProjetoModeloDDD.Application.Interfaces;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> serviceBase;

        public AppServiceBase(IServiceBase<TEntity> _serviceBase)
        {
            serviceBase = _serviceBase;
        }

        public void Add(TEntity obj)
        {
            serviceBase.Add(obj);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return serviceBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return serviceBase.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            serviceBase.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            serviceBase.Update(obj);
        }

        public void Dispose()
        {
            serviceBase.Dispose();
        }
    }
}
