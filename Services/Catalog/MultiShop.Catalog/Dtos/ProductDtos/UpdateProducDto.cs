﻿using MultiShop.Catalog.Entities;

namespace MultiShop.Catalog.Dtos.ProductDtos
{
    public class UpdateProducDto
    {
        public string ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }

        public string ProductImgUrl { get; set; }

        public string ProductDescription { get; set; }

        public string CategoryId { get; set; }

    }
}
