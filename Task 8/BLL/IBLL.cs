﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IBLL<T>
    {
        void Create(T item);
        bool DeleteByID(Guid id);
        bool Update(T t);
        List<T> GetAll();
        T GetByID(Guid id);
    }
}
