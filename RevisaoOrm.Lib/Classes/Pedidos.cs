namespace revisaoOrm.Classes
{
    public class Pedidos
    {
        public int Id {get; set;}
        public DateTime DataPedido {get; set;}
        public string Status {get; set;}
        public Transportadores Transportadora {get; set;}
        public Usuarios Usuario {get; set;}
        public int IdTransportadora {get; set;}
        public int IdUsuario {get; set;}
        public int IdProdutosXPedidos {get; set;}
        public List<ProdutosXPedidos> ProdutosXPedidos { get; set; }  

    }
}