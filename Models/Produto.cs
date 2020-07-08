namespace Conceitos.Models
{
    public class Produto
    {
         //propriedades
        public int Codigo {get; set;}
        public string Nome { get; set; }
        public float Preco { get; set; }
        private const string PATH_ARQUIVO = "Database/produto.csv";


        public List<Produtos> Ler(){
              //criando uma lista de produtos
              List<Produtos> produtos = new List<Produtos>();
              //grava as linhas do banco de dados 
              string[] linhas = File.ReadAllLines(PAHT_ARQUIVO);
              //analise de todas as linhas do banco de dados
              foreach(string a_linha in linhas){
                  //separação das dados de cada linha
                  string[] dados = a_linha.Split(";");
                  //cria um novo produto com os dados ja separados (objeto)
                  //convertanto dados em int e float
                  Produtos o_produto = new Produtos(Int32.Parse(dados[0]),dados[1], float.Parse(dados[2]));
                  //adicionando os itens na lista
                  produtos.Add(o_produto);
              }
              //testando a biblioteca LINQ
              //Organização em ordem alfabetica
              produtos = produtos.OrderBy(o_produto => o_produto.Nome).ToList();

              //retorna a lista
              return produtos;
          }
          //fim do metodo
    }
}