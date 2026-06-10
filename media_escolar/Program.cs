// Algoritmo para calcular média escolar com base em 4 notas.
double num1 = 0.0;
double num2 = 0.0;
double num3 = 0.0;
double num4 = 0.0;
double media = 0.0;

// Interação com o usuário
Console.Write("Digite sua primeira nota: ");
num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite sua segunda nota: ");
num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite sua terceira nota: ");
num3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite sua quarta nota: ");
num4 = Convert.ToDouble(Console.ReadLine());

media = (num1 + num2 + num3 + num4) / 4;

if (media >= 7)
{
    Console.WriteLine($"Você foi aprovado!!! Sua média foi {media}");
}
else{
    Console.WriteLine($"Você foi reprovado!!! sua media foi {media}");
}

 
