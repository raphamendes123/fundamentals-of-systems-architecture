using System;
using System.Linq;

namespace DesignPatterns.Strategy
{
    public class PayPalGateway : IPayPalGateway
    {
        //simulacao o comportamento
        public bool CommitTransaction(string cardHashKey, string orderId, decimal amount)
        {
            return new Random().Next(2) == 0;
        }

        //pegar os dados do cartao e gerar um hash
        public string GetCardHashKey(string serviceKey, string cartaoCredito)
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }

        //especie de chave do paypal para conversar com gateway de pagamento.
        public string GetPayPalServiceKey(string apiKey, string encriptionKey)
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}