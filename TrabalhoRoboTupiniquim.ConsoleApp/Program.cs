System.Console.WriteLine("Digite a posição incial do Robô no eixo X: ");
int posIniX = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Digite a posição incial do Robô no eixo Y: ");
int posIniY = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Digite o sentido inicial do Robô (N, S, L, O): ");
string? senIni = Console.ReadLine();

System.Console.WriteLine("Digite os comandos para virar e movimentar o Robô:");
System.Console.WriteLine("E - Para virar a esquerda.");
System.Console.WriteLine("D - Para virar a direita.");
System.Console.WriteLine("M - Para mover.");
string comandos = Console.ReadLine();

char[] instrucoes = comandos.ToCharArray();

int x = posIniX;
int y = posIniY;
string sentido = senIni;

for (int i = 0; i < instrucoes.Length; i++)
{
    if (instrucoes[i] == 'E')
    {
        if (sentido == "N")
        {
            sentido = "O";
        }
        else if (sentido == "S")
        {
            sentido = "L";
        }
        else if (sentido == "L")
        {
            sentido = "N";
        }
        else
        {
            sentido = "S";
        }
    }
    else if (instrucoes[i] == 'D')
    {
        if (sentido == "N")
        {
            sentido = "L";
        }
        else if (sentido == "S")
        {
            sentido = "O";
        }
        else if (sentido == "L")
        {
            sentido = "S";
        }
        else
        {
            sentido = "N";
        }
    }
    else if (instrucoes[i] == 'M')
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

System.Console.WriteLine("Posição Final: ");
System.Console.WriteLine("X = " + x);
System.Console.WriteLine("Y = " + y);
System.Console.WriteLine("Direção = " + sentido);
Console.ReadLine();



