using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Chain
{
    public class BoletoBancario : FormaPagamento
    {
        public override void ProcessarPagamento(double valor)
        {
            if (valor <= 3000)
            {
                Console.WriteLine("Pagamento de R$" + valor + " realizado com Boleto Bancário.");
            }
            else
            {
                Console.WriteLine("Pagamento de R$" + valor + " excedeu o limite para Boleto Bancário.");
            }
        }
    }

}
