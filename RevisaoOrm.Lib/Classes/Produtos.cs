namespace revisaoOrm.Classes
{
    public class Produtos
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Descricao {get; set;}
        public float Valor {get; set;}
        public DateTime Data_Cadastro {get; set;}
        public int Id_Vendedor {get; set;}
    }
}