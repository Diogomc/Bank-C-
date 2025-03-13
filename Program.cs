
Console.WriteLine("-------------------------");

int scan = 0;
double saldo = 10;

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
                Console.WriteLine($"Saldo Atual: R$ {saldo}");
                break;
            case 2:
                Console.WriteLine("Digite a quantia que deseja sacar: ");
                double saque = Convert.ToDouble(Console.ReadLine());

                if (saque > saldo)
                {
                    Console.WriteLine("Saldo Insuficiente");
                }
                else
                {
                    saldo =- saque;
                }

                Console.WriteLine(saldo);
                break;
            case 3:
                double deposito = Convert.ToDouble(Console.ReadLine());
                saldo += deposito;
                Console.WriteLine($"Seu saldo atual com o depósito: R$ {saldo}");
                break;

            default:
                Console.WriteLine("Obrigado por utilizar nosso banco!");
                Console.WriteLine("Saindo...");
                break;
        }
    }
}

