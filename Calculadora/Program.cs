double n1, n2;

double adc;
double sub;
double mult;
double div;

int opcao = 0;
int continuar = 0;

do
{
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

    do
    {
        Console.WriteLine("\nSelecione qual operação fazer:");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        opcao = int.Parse(Console.ReadLine());
    } while (opcao < 1 || opcao > 4);

    if (opcao == 1)
    {
        adc = n1 + n2;
        Console.WriteLine($"\n{n1} + {n2} = {adc}");
    }
    else if (opcao == 2)
    {
        sub = n1 - n2;
        Console.WriteLine($"\n{n1} - {n2} = {sub}");
    }
    else if (opcao == 3)
    {
        mult = n1 * n2;
        Console.WriteLine($"\n{n1} * {n2} = {mult}");
    }
    else
    {
        div = n1 / n2;
        Console.WriteLine($"\n{n1} / {n2} = {div}\n");
    }

    do
    {
        Console.WriteLine("\nDeseja continuar?");
        Console.WriteLine("1 - Sim");
        Console.WriteLine("2 - Não");
        continuar = int.Parse(Console.ReadLine());
    }while(continuar < 0 || continuar > 2);

} while (continuar == 1);