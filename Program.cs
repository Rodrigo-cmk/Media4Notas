using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {


            double nota1;
            double nota2;
            double nota3;
            double nota4;
            double resul;
            DateTime agora = DateTime.Now;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Olá!                         {agora}");
            Console.WriteLine("     --- Média de 04 notas ---");
            Console.WriteLine();

            Console.WriteLine("|---");
            Console.Write("|- Insira a Nota 01: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("|");

            if (nota1 < 0.0 || nota1 > 10.0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Favor inserir notas somente entre 0,0 e 10,0.");
                Console.ResetColor();
                Environment.Exit(-1);
            }


            Console.Write("|- Insira a Nota Nota 02: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("|");

            if (nota2 < 0.0 || nota2 > 10.0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Favor inserir notas somente entre 0,0 e 10,0.");
                Console.ResetColor();
                Environment.Exit(-1);
            }


            Console.Write("|- Insira a Nota 03: ");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("|");

            if (nota3 < 0.0 || nota3 > 10.0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Favor inserir notas somente entre 0,0 e 10,0.");
                Console.ResetColor();
                Environment.Exit(-1);
            }


            Console.Write("|- Insira a Nota Nota 04: ");
            nota4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("|---");

            if (nota4 < 0.0 || nota4 > 10.0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Favor inserir notas somente entre 0,0 e 10,0.");
                Console.ResetColor();
                Environment.Exit(-1);
            }


            resul = (nota1 + nota2 + nota3 + nota4) / 4;

            
            if (resul < 5.0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Beep();
                Console.WriteLine($"* Média {resul:N1}. Você está 'Reprovado'.");
                Console.ResetColor();
            }

            if (resul >= 5.0 && resul <= 5.9)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Beep();
                Console.Beep();
                Console.WriteLine($"* Média {resul:N1}. Você terá que ficar de 'Recuperação'.");
                Console.ResetColor();
            }

            if (resul >= 6.0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.WriteLine($"* Média {resul:N1}. Parabéns você está 'Aprovado'.");
                Console.ResetColor();
            }




        }
    }
}
