using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            string continuarJuego = "s";
            while (continuarJuego == "s")
            {
                Random aleatorio = new Random();
                int dado1 = aleatorio.Next(1, 13);
                int total = dado1;

                string continuar = "";
                int contador = 0;
                int anterior = 0;

                Console.WriteLine("Obtenga 100 o mas para ganar.");
                Console.WriteLine("Ustede tiene 3 tiros libres, perdera si una vez pasados los 3 turnos saca un numero impar.");
                Console.WriteLine("Si obtine un 12 seguido de un 10 ganara automaticamente.");

                Console.WriteLine("dado: " + dado1);
                Console.WriteLine("Total: " + total);

                Console.WriteLine("Dijite 's' para lanzar nuevamente o 'f' para finalizar partida");
                continuar = Console.ReadLine();

                while (continuar == "s" && total < 100)
                {
                    anterior = dado1;
                    dado1 = aleatorio.Next(1, 13);
                    Console.WriteLine("dado: " + dado1);
                    contador++;
                    total += dado1;
                    Console.WriteLine("Total: " + total);

                    if (anterior == 12 && dado1 == 10)
                        total = 100;

                    if (total >= 100)
                    {
                        continuar = "f";
                        Console.WriteLine("Ganó");
                        Console.WriteLine(" ");
                    }

                    if (total < 100 && contador < 3)
                    {
                        Console.WriteLine("Dijite 's' para lanzar nuevamente o 'f' para finalizar partida");
                        continuar = Console.ReadLine();
                    }

                    if (contador >= 3)
                    {
                        if (dado1 % 2 != 0)
                        {
                            continuar = "f";
                            Console.WriteLine("Perdió");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            Console.WriteLine("Dijite 's' para lanzar nuevamente o 'f' para finalizar partida");
                            continuar = Console.ReadLine();
                        }
                    }
                }

                Console.WriteLine(" ");

                Console.WriteLine("¿Desea jugar otra vez? (digite 's' para si o 'n' para no)");
                continuarJuego = Console.ReadLine();
            }
        }
    }
}
