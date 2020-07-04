using System;

namespace RetContorno
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura, largura, meio = 1;
            bool vlvalido; //vl = valor 

            Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(" ----- CONTORNO ----- \n");

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Largura...:");
            vlvalido = Int32.TryParse (Console.ReadLine(), out largura);

            Console.Write("Altura...:");
            vlvalido = Int32.TryParse (Console.ReadLine(), out altura);

            if (!vlvalido || largura < 1 || largura > 10)
        
           {
            Console.Write("Programa finalizado: valor ");
                      Console.ForegroundColor = ConsoleColor.DarkRed;
                              Console.WriteLine("INVÁLIDO.");
                                      Console.ForegroundColor = ConsoleColor.White;
                                              Environment.Exit(-1);
           }

           else
                {
                    int linhac = 1;
                    Console.ForegroundColor = ConsoleColor.White;
                    while (linhac <= largura)

                    {
                    Console.Write("* ");
                    linhac++;
                    }

                    Console.WriteLine();
                    int p1 = altura - 2; // passo 1
                    while(meio <= p1)
                       
                    {
                        int p2 = 1; // passo 2
                        Console.Write("* ");
                        int result = largura - 2;
                        while (p2 <= result)
                    {

                        Console.Write("  ");
                        p2++;
                     
                     }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("* ");
                        Console.WriteLine();
                        meio++;

                     }
                        int linha2 = 1;
                        Console.ForegroundColor = ConsoleColor.White;
                        while (linha2 <= largura)
                     {

                        Console.Write("* ");
                        linha2++;

                }

                Console.WriteLine("\nPressione enter para finalizar <3 ");
                        Console.ReadKey();
        }
     }
   }
}



