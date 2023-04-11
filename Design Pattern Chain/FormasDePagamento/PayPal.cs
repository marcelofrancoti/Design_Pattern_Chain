using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Chain
{
    public class PayPal : FormaPagamento
    {
        public override void ProcessarPagamento(double valor)
        {
            if (valor <= 500)
            {
                Console.WriteLine("Pagamento de R$" + valor + " realizado com PayPal.");
            }
            else if (proximo != null)
            {
                Console.WriteLine("Pagamento de R$" + valor + " excedeu o limite para PayPal. Processando com próxima forma de pagamento...");
                proximo.ProcessarPagamento(valor);
            }
            else
            {
                Console.WriteLine("Pagamento de R$" + valor + " excedeu o limite para todas as formas de pagamento.");
            }
        }
    }

}
