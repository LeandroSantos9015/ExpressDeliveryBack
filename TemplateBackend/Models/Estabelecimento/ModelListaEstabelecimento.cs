using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateBackend.Models.Estabelecimento
{
    public class ModelListaEstabelecimento
    {

        public Int64 Id { get; set; }

        public Int64 IdUsuario { get; set; }

        public Int64 IdEndereco { get; set; }

        public bool Ativo { get; set; }

        public bool Online { get; set; }

        public Decimal TaxaEntrega { get; set; }

        public Int64 IdCategoria { get; set; }

        public bool ChegouPedido { get; set; }

        public String FormasPagamento { get; set; }

        public Decimal PedidoMinimo { get; set; }

        public DateTime DataCriacao { get; set; }

        public string Logo { get; set; }

        public string Rua { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Categoria { get; set; }

    }
}