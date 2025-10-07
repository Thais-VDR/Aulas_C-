using aula3;

Pedido pedido = new Pedido();
pedido.FormaPagamentoDinheiro();

var produto = new Produto()
{
    Nome = "Kitubaina",
    Quantidade = 1,
    Preco = 8
};
pedido.AdicionarListaProduto(produto);

produto = new Produto()
{
    Nome = "Leite",
    Quantidade = 3,
    Preco = 6
};
pedido.AdicionarListaProduto(produto);


pedido.MostrarLista(pedido.ListaProdutos);