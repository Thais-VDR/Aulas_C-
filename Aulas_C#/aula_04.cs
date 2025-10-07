using aula04;

int iniciarPrograma = 1;

Controller _controller = new Controller();
Console.WriteLine(" Programa Iniciado! ");
_controller.MostrarMenu();
while (iniciarPrograma == 1)
{
    
   
    int opcao = int.Parse(Console.ReadLine()!);
    iniciarPrograma = _controller.ProcessarOpcao(opcao);
    
}