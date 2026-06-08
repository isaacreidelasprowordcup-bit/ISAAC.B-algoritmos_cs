// Declaração de variáveis
    {
        double lado1, lado2, lado3;

        Console.Write("Digite o primeiro lado: ");
        lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo lado: ");
        lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o terceiro lado: ");
        lado3 = Convert.ToDouble(Console.ReadLine());

        if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine(" O Triângulo é Equilatero!!! ");
        }
        else
        {
            if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine(" O Triângulo é Isosceles!!! ");
            }
            else
            {
                Console.WriteLine(" O Triângulo é Escaleno!!! ");
            }
        }
    }
