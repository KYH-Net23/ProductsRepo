﻿using CreateProducts.Models;

namespace CreateProducts.Interfaces
{
    public interface IProductService
    {
        public Task CreateNewProduct(ProductModel model);
    }
}