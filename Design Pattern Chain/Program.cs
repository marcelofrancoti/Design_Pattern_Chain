using System;

namespace Design_Pattern_Chain
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configura o fluxo de pagamento
            FormaPagamento cartaoCredito = new CartaoCredito();
            FormaPagamento payPal = new PayPal();
            FormaPagamento boletoBancario = new BoletoBancario();

            cartaoCredito.SetProximo(payPal);
            payPal.SetProximo(boletoBancario);

            // Cliente realiza o pagamento
            Cliente cliente = new Cliente();
            cliente.SetFormaPagamento(cartaoCredito);

            // Realiza pagamentos com diferentes valores
            cliente.RealizarPagamento(800); // Pagamento de R$800 realizado com Cartão de Crédito.
            cliente.RealizarPagamento(1500); // Pagamento de R$1500 excedeu o limite para Cartão de Crédito. Processando com próxima forma de pagamento...
                                             // Pagamento de R$1500 realizado com PayPal.
            cliente.RealizarPagamento(3500); // Pagamento de R$3500 excedeu o limite para PayPal. Processando com próxima forma de pagamento...
                                             // Pagamento de R$3500 excedeu o limite para Boleto Bancário.
        }
    }
}
