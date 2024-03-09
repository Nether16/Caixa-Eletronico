for (int i = 0; i < 1; i = 0)
{
    Console.WriteLine("Escolhe a operação que voce quer fazer : ");
    Console.WriteLine("1 - Saldo");
    Console.WriteLine("2 - Saque");
    Console.WriteLine("3 - Deposito ");
    int operação = int.Parse(Console.ReadLine());

    float saldo = 0;

    switch (operação)
    {
        case 1:
            Console.WriteLine($"Seu saldo é {saldo}");
            break;
        case 2:
            Console.WriteLine("Digite a quantidade a ser sacada");
            float saque = float.Parse(Console.ReadLine());
            saldo -= saque;
            Console.WriteLine($"Seu saldo agora é {saldo}");
            break;
        case 3:
            Console.WriteLine("Digite a quantidade a ser depositada");
            float deposito = float.Parse(Console.ReadLine());
            saldo += deposito;
            Console.WriteLine($"Seu saldo agora é {saldo}");
            break;
    }
    Console.WriteLine("");
}