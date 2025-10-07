//CTRL + K + C

var soma = 0;

Console.WriteLine("Digite um número: ");
int cont = Convert.ToInt32(Console.ReadLine());

for(int i = 0 ; i < cont; i++)
{
    soma++;
}

Console.WriteLine($"O total da soma é: {soma}");