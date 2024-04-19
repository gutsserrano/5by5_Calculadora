double n1, n2;

double adc;
double sub;
double mult;
double div;

Console.WriteLine("Digite o primeiro valor: ");
n1 = double.Parse(Console.ReadLine());

do
{
    Console.WriteLine("Digite o segundo valor: ");
    n2 = double.Parse(Console.ReadLine());

    if (n2 == 0)
    {
        Console.WriteLine("**N2 não pode ser 0 pois é impossível dividir por 0**\n");
    }
} while (n2 == 0);

adc = n1 + n2;
sub = n1 - n2;
mult = n1 * n2;
div = n1 / n2;

Console.WriteLine($"{n1} + {n2} = {adc}");
Console.WriteLine($"{n1} - {n2} = {sub}");
Console.WriteLine($"{n1} * {n2} = {mult}");
Console.WriteLine($"{n1} / {n2} = {div}\n");


Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();