﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaAPI.Domain.Models
{
    public class CompraProdutoModel
    {
        public int CompraId { get; set; }
        public CompraModel Compra { get; set; }

        public int ProdutoId { get; set; }
        public ProdutoModel Produto { get; set; }
    }
}