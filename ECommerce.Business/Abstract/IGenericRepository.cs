﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface IGenericRepository<Tentity>
          where Tentity : class, new()
    {
        List<Tentity> GetAll(Expression<Func<Tentity, bool>> filter = null);
        Tentity Get(int id);
        Tentity Get(Expression<Func<Tentity, bool>> filter);
        void Add(Tentity entity);
        void Update(Tentity entity);
        void Delete(int id);
        void Delete(Tentity entity);

    }
}
