//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoDA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pagamento
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public string MetodoPagamentoId { get; set; }
        public int PedidoId { get; set; }
        public int MetodoPagamentoId1 { get; set; }
    
        public virtual Pedido Pedido { get; set; }
        public virtual MetodoPagamento MetodoPagamento { get; set; }
    }
}