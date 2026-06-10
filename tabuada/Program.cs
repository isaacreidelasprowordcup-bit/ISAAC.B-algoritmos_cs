// Algoritmo para exibir a tabuada de um número do 1 ao 10

double num = 0.0;
double multiplicador = 1;
double resultado = num * multiplicador;

// Interação com usuário

Console.WriteLine("Insira um valor: ");
num = Convert.ToDouble(Console.ReadLine());

while (multiplicador <= 10)
{
    resultado = num * multiplicador;
    Console.WriteLine($"{num} x {multiplicador} = {resultado}");
    multiplicador++;
}
{
    Console.WriteLine("fim da tabuada!");
    Console.WriteLine("-----------");
    Console.ReadLine();
}
