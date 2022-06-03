namespace revisaoOrm.Classes
{
    public class Produtos
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Descricao {get; set;}
        public float Valor {get; set;}
        public DateTime Data_Cadastro {get; set;}
        public int IdVendedor {get; set;}
        public Vendedores Vendedor {get; set;}
        public List<Produtos_X_Pedidos> Produtos_X_Pedidos { get; set; }
    }
}