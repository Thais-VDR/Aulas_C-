using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3
{
  public class Produto
    {
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    }

    public class Pedido
    {
        public List<Produto> ListaProdutos { get; set; } = new List<Produto>();


        public void AdicionarListaProduto(Produto produto)
        {
            ListaProdutos.Add(produto);
        }

        public void MostrarLista(List<Produto> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"{lista[i].Nome} - {lista[i].Preco}");
            }
        }
        public void FormaPagamentoCartao()
        {
            Console.WriteLine("Pago com Cartão");
        }
        public void FormaPagamentoCheque()
        {
            Console.WriteLine("Pago com Cheque");
        }
        public void FormaPagamentoDinheiro()
        {
            Console.WriteLine("Pago com Dinheiro");
        }
    }
}
