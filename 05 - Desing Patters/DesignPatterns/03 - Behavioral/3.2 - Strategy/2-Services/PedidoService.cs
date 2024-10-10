namespace DesignPatterns
{
    public class PedidoService
    {
        private readonly IPagamento _pagamento;
        
        public PedidoService(IPagamento pagamento)
        {
            _pagamento = pagamento;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            //Stategy abstrata e nao especializada.

            return _pagamento.RealizarPagamento(pedido, pagamento);
        }
    }
}