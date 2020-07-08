using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Conceitos.Controllers;
namespace Conceitos.Views
{
    public class ProdutoView
    {
       public void MostrarNoConsole(List<Produto> lista){
           foreach(Produto item in lista){
               Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
           }
       }
       
    }
}