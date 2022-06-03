namespace revisaoOrm.Classes
{
    public class Transportadores
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Telefone {get; set;}
        public string Email {get; set;}
        public List<Pedidos> Pedidos {get; set;}
    }
}