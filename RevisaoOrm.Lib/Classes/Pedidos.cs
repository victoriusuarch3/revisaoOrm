namespace revisaoOrm.Classes
{
    public class Pedidos
    {
        public int Id {get; set;}
        public DateTime DataPedido {get; set;}
        public string Status {get; set;}
        public int Id_Transportadora {get; set;}
        public int Id_Usuario {get; set;}
        public List<Produtos_X_Pedidos> Produtos_X_Pedidos { get; set; }  

    }
}