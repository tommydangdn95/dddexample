﻿using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public interface IProductRepository
    {
        Task CreateProductAsync(Product product);
    }
}
