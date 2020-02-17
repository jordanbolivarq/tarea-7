using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            string continuarJuego = "s";
            while (continuarJuego == "s")
            {
                Random aleatorio = new Random();
                int dado1 = aleatorio.Next(1, 7);
                int dado2 = 0;
                int total = dado1;
                
                string continuar = "";
                int vidas = 3;
                int turnosVidas = 2;
                int contador = 1;
                int contador2 = 1;

                Console.WriteLine("obtenga 100 o mas para ganar.");
                Console.WriteLine("Ustede tiene " + vidas + " vidas, perdera 1 cada " + turnosVidas + " turnos. Si se queda sin vidas pierde." );
                Console.WriteLine("Cada 3 turnos podra lanzar 2 dados, si obtine par (ambos dados con igual valor) obtendra otra vida.");

                Console.WriteLine("dado: " + dado1);
                Console.WriteLine("Total: " + total);

                Console.WriteLine("Dijite 's' para lanzar nuevamente o 'f' para finalizar partida");
                continuar = Console.ReadLine();

                while (continuar == "s" && total < 100 && vidas > 0)
                {
                    dado1 = aleatorio.Next(1, 7);
                    Console.WriteLine("dado: " + dado1);
                    contador++;
                    contador2++;

                    if (contador == 3)
                    {
                        dado2 = aleatorio.Next(1, 7);
                        Console.WriteLine("dado 2: " + dado2);
                        contador = 0;
                        total += dado1 + dado2;
                    }
                    else
                        total += dado1;

                    Console.WriteLine("Total: " + total);

                    if (contador2 == turnosVidas)
                    {
                        vidas -= 1;
                        contador2 = 0;
                    }

                    if (dado1 == dado2)
                        vidas++;

                    Console.WriteLine("Vidas: " + vidas);

                    if (total < 100 && vidas > 0)
                    {
                        Console.WriteLine("Dijite 's' para lanzar nuevamente o 'f' para finalizar partida");
                        continuar = Console.ReadLine();
                    }
                    else if (vidas <= 0 && total < 100)
                        Console.WriteLine("Perdió");
                }

                Console.WriteLine(" ");

                Console.WriteLine("¿Desea jugar otra vez? (digite 's' para si o 'n' para no)");
                continuarJuego = Console.ReadLine();
            }
        }
    }
}
