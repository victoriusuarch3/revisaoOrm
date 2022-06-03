namespace revisaoOrm.Classes
{
    public class Usuarios
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Cpf {get; set;}
        public DateTime Data_Nascimento {get; set;}
        public string Senha {get; set;} 
        public Pedidos pedidos {get; set;}
        public List<Pedidos> PegarPedidos { get; set; }
    }
}