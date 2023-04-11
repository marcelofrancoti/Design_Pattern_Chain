using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Chain
{
    public abstract class FormaPagamento
    {
        protected FormaPagamento proximo;

        // Define o próximo handler na corrente
        public void SetProximo(FormaPagamento proximo)
        {
            this.proximo = proximo;
        }

        // Processa o pagamento
        public abstract void ProcessarPagamento(double valor);
    }
}
