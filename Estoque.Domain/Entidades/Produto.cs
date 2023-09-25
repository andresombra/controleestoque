﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Domain.Entidades
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Descricao { get; set; } = string.Empty;   
        public decimal Valor { get; set; }
        public int CategoriaId { get; set; }
    }
}
