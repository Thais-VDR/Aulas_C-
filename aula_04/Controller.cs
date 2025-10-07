namespace aula04
{
    public class Controller
    {
        public List<Livro> _livros = new List<Livro>();
        private int _nextId = 1;


        public int ProcessarOpcao(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    Livro newLivro = new Livro();
                    Console.WriteLine("Digite o nome do livro: ");
                    newLivro.Nome = Console.ReadLine()!;
                    Console.WriteLine("Digite o preço do livro: ");
                    newLivro.Preco = decimal.Parse(Console.ReadLine()!);
                    newLivro.Ativo = true;
                    Create(newLivro);
                    MostrarMenu();
                    return 1;

                case 2:
                    Console.Clear();
                    GetAll();
                    MostrarMenu();
                    return 1;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Digite o ID do Livro: ");
                    int id = int.Parse(Console.ReadLine()!);
                    var livro = BuscarPorId(id);
                    if(livro != null)
                    {
                    Console.WriteLine($"livro: {livro.Nome}");
                    }
                    return 1;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Digite o ID do livro: ");
                    int idLivro = int.Parse(Console.ReadLine()!);
                    var LivroUpdade = new Livro();
                    Console.WriteLine("Digite o nome: ");
                    LivroUpdade.Nome = Console.ReadLine()!;
                    Console.WriteLine("Digite o preço: ");
                    LivroUpdade.Preco = decimal.Parse(Console.ReadLine()!);
                    Atualizar(idLivro, LivroUpdade);
                    return 1;

                    case 5:
                    Console.Clear();
                    Console.WriteLine("Digite o ID: ");
                    int idRemove = int.Parse(Console.ReadLine()!);
                    RemoverPorId(idRemove);
                    return 1;

                case 6:
                    Console.Clear();
                    Console.WriteLine("Fechar Programa!");
                    MostrarMenu();
                    return 0;
                    
                default:
                    Console.Clear();
                    Console.WriteLine("opção inválida!");
                    MostrarMenu();
                    return 1;
            }
        }
        public void MostrarMenu()
        {
            Console.WriteLine(" ========================================= ");
            Console.WriteLine("            Escolha uma opção:             ");
            Console.WriteLine(" ========================================= ");
            Console.WriteLine("1 - Cadastrar Livros");
            Console.WriteLine("2 - Listar Todos os Livros");
            Console.WriteLine("3 - Buscar Livro pelo ID");
            Console.WriteLine("4 - Atualizar Livro");
            Console.WriteLine("5 - Deletar Livro");
            Console.WriteLine("6 - Fechar o Programa");
            Console.WriteLine(" ========================================= ");
        }
        public void Create(Livro newLivro)
        {

            newLivro.Id = _nextId;
            _livros.Add(newLivro);// Adicionando Livros.
            _nextId++;
            Console.WriteLine("Livro cadastrado com sucesso!");
        
        }

        public void GetAll()
        {
            var listaLivros =  _livros.Select(l => l).ToList();//Encontra e seleciona os livros e joga em uma lista.
            
            for (int i = 0; i < listaLivros.Count; i++)
            {
                Console.WriteLine($"Id: {listaLivros[i].Id} - Nome: {listaLivros[i].Nome} - Preço: {listaLivros[i].Preco} - Ativo: {listaLivros[i].Ativo}");
            }
        }

        public void Atualizar(int id, Livro newLivro)
        {
            var oldLivro = _livros.FirstOrDefault(l => l.Id == id);

            if (oldLivro != null)
            {
                oldLivro.Nome = newLivro.Nome;
                oldLivro.Ativo = true;
                oldLivro.Preco = newLivro.Preco;
                Console.WriteLine("Livro Atualizado!");
            }
            else  
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }
        public Livro BuscarPorId(int id)
        {
            return _livros.FirstOrDefault (l => l.Id == id);
        }

        public void RemoverPorId(int id)
        {
            var LivroRemove =  _livros.FirstOrDefault(l => l.Id == id);
            if(LivroRemove != null)
            {
                _livros.Remove(LivroRemove);
            }        
        }

    }
}
