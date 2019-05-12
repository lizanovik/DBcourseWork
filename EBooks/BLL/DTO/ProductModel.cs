﻿using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Supplier Supplier { get; set; }
        public string CompanyName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
    }
}