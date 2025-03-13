
Console.WriteLine("-------------------------------");



int scan = 0;

while (scan != 4)
{

    Console.WriteLine("1 - Consultar Saldo");
    Console.WriteLine("2 - Sacar");
    Console.WriteLine("3 - Depositar");
    Console.WriteLine("4 - Sair");

    scan = Convert.ToInt16(Console.ReadLine());
    {

        switch (scan)
        {
            case 1:
                Console.WriteLine("Apertou 1");
                break;
            case 2:
                Console.WriteLine("Apertou 2");
                break;
            default:
                Console.WriteLine("Número inválido");
                break;
        }
    }
}

