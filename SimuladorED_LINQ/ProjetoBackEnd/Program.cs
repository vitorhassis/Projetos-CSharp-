class Program
{
    static void Main()
    {
        int opcao;
        do
        {
            Console.WriteLine("========MENU PRINCIPAL========");
            Console.WriteLine("\n1-Pilha\n2-Fila\n3-Listas\n4-Sair");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("========MENU PRINCIPAL -> PILHA <- ========");
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("========MENU PRINCIPAL -> FILA <- ========");
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("======== MENU PRINCIPAL -> LISTA <- ========");
                    break;
            }

        } while (opcao != 4);

    }
}