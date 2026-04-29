class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Digite a posição inicial do Robô no eixo X: ");
        int posIniX = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a posição inicial do Robô no eixo Y: ");
        int posIniY = Convert.ToInt32(Console.ReadLine());

        string sentido;
        while (true)
        {
            Console.WriteLine("Digite o sentido inicial do Robô (N, S, L, O): ");
            sentido = Console.ReadLine().ToUpper();

            if (sentido == "N" || sentido == "S" || sentido == "L" || sentido == "O")
            {
                break;
            }

            Console.WriteLine("Sentido inválido! Use apenas N, S, L ou O.");
        }

        string comandos;
        while (true)
        {
            Console.WriteLine("Digite os comandos para virar e movimentar o Robô:");
            Console.WriteLine("E - Para virar a esquerda.");
            Console.WriteLine("D - Para virar a direita.");
            Console.WriteLine("M - Para mover.");

            comandos = Console.ReadLine().ToUpper();

            bool valido = true;

            for (int i = 0; i < comandos.Length; i++)
            {
                char c = comandos[i];

                if (c != 'E' && c != 'D' && c != 'M')
                {
                    valido = false;
                    break;
                }
            }

            if (valido)
            {
                break;
            }

            Console.WriteLine("Comandos inválidos! Use apenas E, D ou M.");
        }

        int x = posIniX;
        int y = posIniY;

        ExecutarComandos(comandos, ref x, ref y, ref sentido);

        Console.WriteLine("\nPosição Final:");
        Console.WriteLine("X = " + x);
        Console.WriteLine("Y = " + y);
        Console.WriteLine("Direção = " + sentido);

        System.Console.WriteLine("Pressione ENTER para sair...");
        Console.ReadLine();
    }

    static void ExecutarComandos(string comandos, ref int x, ref int y, ref string sentido)
    {
        char[] instrucoes = comandos.ToCharArray();

        for (int i = 0; i < instrucoes.Length; i++)
        {
            if (instrucoes[i] == 'E')
            {
                sentido = VirarEsquerda(sentido);
            }
            else if (instrucoes[i] == 'D')
            {
                sentido = VirarDireita(sentido);
            }
            else if (instrucoes[i] == 'M')
            {
                Mover(ref x, ref y, sentido);
            }
        }
    }

    static string VirarEsquerda(string sentido)
    {
        if (sentido == "N")
        {
            return "O";
        }
        else if (sentido == "S")
        {
            return "L";
        }
        else if (sentido == "L")
        {
            return "N";
        }
        else
        {
            return "S";
        }
    }

    static string VirarDireita(string sentido)
    {
        if (sentido == "N")
        {
            return "L";
        }
        else if (sentido == "S")
        {
            return "O";
        }
        else if (sentido == "L")
        {
            return "S";
        }
        else
        {
            return "N";
        }
    }

    static void Mover(ref int x, ref int y, string sentido)
    {
        if (sentido == "N")
        {
            y++;
        }
        else if (sentido == "S")
        {
            y--;
        }
        else if (sentido == "L")
        {
            x++;
        }
        else
        {
            x--;
        }
    }
}