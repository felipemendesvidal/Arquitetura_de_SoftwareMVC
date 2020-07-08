using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Conceitos.Models;
using Conceitos.Views;
namespace Conceitos.Controllers
{
    public class ProdutoController
    {
        Produto produtoModel = new Produto();
        ProdutoView produtoview = new ProdutoView();

        public void Listar(){
            produtoview.MostrarNoConsole( produtoModel.Ler() );
        }
        public void Buscar(string termo){
            List<Produto> buscar = new List<Produto>();
            buscar =buscar.FindAll(x => x.Preco == float.Parse(termo));
            produtoview.MostrarNoConsole(buscar);
        }
    }
}