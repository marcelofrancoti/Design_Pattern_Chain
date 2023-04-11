using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Chain
{
    public class CartaoCredito : FormaPagamento
    {
        public override void ProcessarPagamento(double valor)
        {
            if (valor <= 1000)
            {
                Console.WriteLine("Pagamento de R$" + valor + " realizado com Cartão de Crédito.");
            }
            else if (proximo != null)
            {
                Console.WriteLine("Pagamento de R$" + valor + " excedeu o limite para Cartão de Crédito. Processando com próxima forma de pagamento...");
                proximo.ProcessarPagamento(valor);
            }
            else
            {
                Console.WriteLine("Pagamento de R$" + valor + " excedeu o limite para todas as formas de pagamento.");
            }
        }
    }
}
