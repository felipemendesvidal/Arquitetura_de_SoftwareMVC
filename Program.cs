using System;
using ProdutoController;

namespace Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();
            prod.Listar();
        }
    }
}
