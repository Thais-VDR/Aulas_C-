// Ctrl + K + D - redenriza o codido e deixa organizado.

using aula2;

Calculadora calcular = new Calculadora();
Console.WriteLine("Digite dois valores: ");
int valor1 = Convert.ToInt32(Console.ReadLine());
int valor2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Escolha a operação: ");
Console.WriteLine("===================== ");
Console.WriteLine("1 - Soma ");
Console.WriteLine("2 - Subtração ");
Console.WriteLine("3 - Multiplicação ");
Console.WriteLine("4 - Divisão");
Console.WriteLine("===================== ");
int operacao = Convert.ToInt32(Console.ReadLine());

switch (operacao)
{
    case 1:
        Console.Clear();
        Console.WriteLine($"O valor da soma é: {calcular.Soma(valor1, valor2)}");
        break;
    case 2:
        Console.Clear();
        Console.WriteLine($"O valor da subtração é: {calcular.Subtrair(valor1, valor2)}");
        break;
    case 3:
        Console.Clear();
        Console.WriteLine($"O valor da Multiplicação é: {calcular.Multiplicacao(valor1, valor2)}");
        break;
    case 4:
        Console.Clear();
        Console.WriteLine($"O valor da Divisão é: {calcular.Divisao(valor1, valor2)}");
        break;
    default:
        Console.Clear();
        Console.WriteLine($"Error");
        break;
}






//Onibus onibusEscolar = new Onibus();

//onibusEscolar.Janela = 20;
//onibusEscolar.Passageiro = 40;
//onibusEscolar.Porta = 2;


//Console.WriteLine($"O número de Janelas é {onibusEscolar.Janela}");
//Console.WriteLine($"O número de passageiros é {onibusEscolar.Passageiro}");
//Console.WriteLine($"O número de portas é {onibusEscolar.Porta}");


//class Onibus
//{
//    public int Janela {  get; set; }
//    public int Passageiro { get; set; }
//    public int Porta { get; set; }
//}

