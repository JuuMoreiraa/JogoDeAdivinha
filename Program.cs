//Adivinhe o número

Random aleatorio = new Random();
int numSecreto = aleatorio.Next(1, 101);

do
{
    Console.Write("Adivinhe o número entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine()!);

    if (chute == numSecreto)
    {
        Console.WriteLine("Você acertou o número!!");
        break;
    }
    else if (chute < numSecreto)
    {
        Console.WriteLine("O número é maior do que esse...");
    }
    else
    {
        Console.WriteLine("O número é menor do que esse...");
    }
} while (true);

Console.WriteLine("O jogo terminou :)");


