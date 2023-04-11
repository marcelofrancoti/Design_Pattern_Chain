using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Chain
{
    public class Cliente
    {
        private FormaPagamento formaPagamento;

        // Configura a forma de pagamento
        public void SetFormaPagamento(FormaPagamento formaPagamento)
        {
            this.formaPagamento = formaPagamento;
        }

        // Processa o pagamento
        public void RealizarPagamento(double valor)
        {
            formaPagamento.ProcessarPagamento(valor);
        }
    }

}
