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
        public int IdProdutos_X_Pedidos {get; set;}
        public List<Produtos_X_Pedidos> Produtos_X_Pedidos { get; set; }  

    }
}