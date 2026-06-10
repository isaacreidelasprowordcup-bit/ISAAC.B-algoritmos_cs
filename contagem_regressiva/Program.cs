// Algoritmo que faz uma contagem regressiva com o número seleionado

double numero = 0.0;

// Interação com o usuário

Console.WriteLine("Digite seu número inteiro inicial: ");
numero = Convert.ToDouble(Console.ReadLine());

while (numero > 0)
{
    numero = numero - 1;
    Console.WriteLine(numero);
}
{
    Console.WriteLine("Fim da contagem regressiva!");
}


