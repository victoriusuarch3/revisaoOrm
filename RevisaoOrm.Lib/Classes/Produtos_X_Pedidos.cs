namespace revisaoOrm.Classes
{
    public class Produtos_X_Pedidos
    {
        public int Id {get; set;}
        public Produtos Produto {get; set;}
        public Pedidos Pedido {get; set;}
        public int IdProduto {get; set;}
        public int IdPedido {get; set;}

        

    }
}