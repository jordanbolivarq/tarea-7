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
                 int contador2 = 1;

                Console.WriteLine("obtenga 100 o mas para ganar.");
                Console.WriteLine("Ustede tiene 3 tiros libres, perdera si una vez pasados los 3 turnos saca un numero impar.");
                Console.WriteLine("si obtine un 12 seguido de un 10 ganara automaticamente.");

                Console.WriteLine("dado: " + dado1);
                Console.WriteLine("Total: " + total);

                Console.WriteLine("Dijite 's' para lanzar nuevamente o 'f' para finalizar partida");
                continuar = Console.ReadLine();

                while (continuar == "s" && total < 100)
                {
                    dado1 = aleatorio.Next(1, 13);
                    Console.WriteLine("dado: " + dado1);
                    contador++;
                    total += dado1;
                    Console.WriteLine("Total: " + total);

                    if (contador2 == 0 && dado1 == 12)
                        contador2++;

                    if (contador2 == 1 && dado1 == 10)
                        contador2++;

                    if (contador2 == 1 && dado1 != 10)
                        contador2 = 0;

                    if (contador2 == 2)
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
                        if (dado1 == 1)
                        {
                            continuar = "f";
                            Console.WriteLine("Perdió");
                            Console.WriteLine(" ");
                        }
                        else if (dado1 == 3)
                        {
                            continuar = "f";
                            Console.WriteLine("Perdió");
                            Console.WriteLine(" ");
                        }
                        else if (dado1 == 5)
                        {
                            continuar = "f";
                            Console.WriteLine("Perdió");
                            Console.WriteLine(" ");
                        }
                        else if (dado1 == 7)
                        {
                            continuar = "f";
                            Console.WriteLine("Perdió");
                            Console.WriteLine(" ");
                        }
                        else if (dado1 == 9)
                        {
                            continuar = "f";
                            Console.WriteLine("Perdió");
                            Console.WriteLine(" ");
                        }
                        else if (dado1 == 11)
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
