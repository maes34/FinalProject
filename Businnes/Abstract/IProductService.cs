﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businnes.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategory(int id);
        List<Product> GetByUnitPrice(decimal min, decimal max);
    }
}
