// Declaração das variáveis

int anoNascimento = 0;
int idade = 0;

// Interação com o usuário

Console.WriteLine("Informe o seu ano de nascimento: ");
anoNascimento = Convert.ToInt16(Console.ReadLine());

idade = 2026 - anoNascimento;
if (idade >= 18)
        {
            Console.WriteLine("Voce ja pode tirar a CNH.");
        }
        else
        {
            Console.WriteLine("Voce ainda não pode tirar a CNH.");
        }
        

