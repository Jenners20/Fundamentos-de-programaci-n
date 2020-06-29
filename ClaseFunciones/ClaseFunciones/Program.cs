using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFunciones
{
    class Program
    {
        public static void Jugadores(string Jugador1)
        {
            string Jugada = "";
            int decision = 0;
            Console.WriteLine("---> "+Jugador1+" <---");
            Console.WriteLine("Pulse ( 1 ) para seleccionar piedra ");
            Console.WriteLine();
            Console.WriteLine("Pulse ( 2 ) para seleccionar papel ");
            Console.WriteLine();
            Console.WriteLine("Pulse ( 3 ) para seleccionar tijera ");
            Console.Write("");
            decision = int.Parse(Console.ReadLine());
            switch (decision)
            {
                case 1: Console.WriteLine("Su elección es piedra...");
                    Jugada = "Piedra";
                    break;
                case 2: Console.WriteLine("Su elección es papel...");
                    Jugada = "Papel";
                    break;
                case 3: Console.WriteLine("Su elección es tijera...");
                    Jugada = "Tijera";
                    break;
                default:
                    break;
            }
            Decision(decision,Jugada,Jugador1);
        }
        public static void Decision(int decision,string Jugada,string Jugador1)
        {
            string JugadaM = "";
            int numero = new Random().Next(1, 4);
            int volver = 0;
            Console.WriteLine(numero);
            switch (numero)
            {
                case 1: JugadaM = "Piedra";
                    break;
                case 2: JugadaM="Papel";
                    break;
                case 3: JugadaM = "Tijera";
                    break;
                default:
                    break;
            }
            if (JugadaM==Jugada)
            {
                Console.WriteLine("El usuario ha jugado {0} y la maquina ha jugado {1} ", Jugada, JugadaM);
                Console.WriteLine("Por lo que hay un empate y vamos a volver a jugar...");
                Jugadores(Jugador1);
            }
           if(Jugada=="Papel"&&JugadaM=="Tijera"||Jugada=="Piedra"&&JugadaM=="Papel"||Jugada=="Tijera"&&JugadaM=="Piedra")
            {
                Console.WriteLine("El jugador {0} ha jugado {1} mientras que la máquina ha jugado {2}", Jugador1, Jugada, JugadaM);
                Console.WriteLine("Por lo que la máquina ha ganado!!");
            }
            if (JugadaM == "Papel" && Jugada == "Tijera" || JugadaM == "Piedra" && Jugada == "Papel" || JugadaM == "Tijera" && Jugada == "Piedra")
            {
                Console.WriteLine("El jugador {0} ha jugado {1} mientras que la máquina ha jugado {2}", Jugador1, Jugada, JugadaM);
                Console.WriteLine("Por lo que el Jugador {0} ha ganado!!", Jugador1);
            }
            Vuelve:
            Console.WriteLine();
            Console.WriteLine("¿Quieres volver a jugar? ");
            Console.WriteLine();
            Console.WriteLine("Pulsa (1) para volver a jugar o pulsa (2) para dejar de jugar ");
            volver = int.Parse(Console.ReadLine());
            switch (volver)
            {
                case 1:
                    Console.Clear();
                    Jugadores(Jugador1);
                    break;
                case 2: Console.WriteLine("Cerrando el Juego...");
                    break;
                default: goto Vuelve;
                    break;
            }
        }

    static void Main(string[] args)
        {
            string Jugador = "Player1";
        

            Jugadores(Jugador);
            

            Console.ReadKey();
        }
      
    }
}
