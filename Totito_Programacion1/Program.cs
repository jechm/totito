using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totito_Programacion1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            /*para el tablero
             * Alt 185  ╣
             * Alt 186 ║
             * Alt 187  ╗
             * Alt 188 ╝
             * Alt 200 ╚
             * Alt 201 ╔
             * ALt 202  ╩
             * Alt 203 ╦
             * Alt 204  ╠
             * Alt 205 ═
             * Alt 206 ╬ 
             */
            Console.WriteLine("Totito");
            String posicion;
            String tablero, p1 = " ", p2 = " ", p3 = " ", p4 = " ", p5 = " ", p6 = " ", p7 = " ", p8 = " ", p9=" ";
            String fichaActual, j1 = "X", j2 = "O";
            String nombreJ1 = "Player 1", nombreJ2 = "Player 2";
            String jugadorEnTurno;
            int Contador = 1; //cuando el contador llegue a 9 o hay ganador o hay empate
            Boolean hayGanador = false;
            Boolean cambiarJugador;

            //datos de los jugadores
            Console.WriteLine("Ingrese el nombre del primer jugador");
            nombreJ1 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del segundo jugador");
            nombreJ2 = Console.ReadLine();

            jugadorEnTurno = nombreJ1;

            while (!hayGanador)
            {
                cambiarJugador = true;
                //Marcar la ficha que esta en juego j1 = X j2 = O
                fichaActual = jugadorEnTurno.Equals(nombreJ1) ? j1 : j2;

                Console.WriteLine($"Es el turno de {jugadorEnTurno}");

                posicion = Console.ReadLine();

                switch (posicion)
                {
                    case "1":

                        if (p1.Equals(" "))
                        {
                            p1 = fichaActual;
                        }
                        else
                        {
                            
                            cambiarJugador = false;
                        }
                        break;
                    case "2":

                        if (p2.Equals(" "))
                        {
                            p2 = fichaActual;
                        }
                        else
                        {
                            
                            cambiarJugador = false;
                        }
                        break;
                    case "3":

                        if (p3.Equals(" "))
                        {
                            p3 = fichaActual;
                        }
                        else
                        {
                            
                            cambiarJugador = false;
                        }
                        break;
                    case "4":

                        if (p4.Equals(" "))
                        {
                            p4 = fichaActual;
                        }
                        else
                        {
                            
                            cambiarJugador = false;
                        }
                        break;
                    case "5":

                        if (p5.Equals(" "))
                        {
                            p5 = fichaActual;
                        }
                        else
                        {
                           
                            cambiarJugador = false;
                        }
                        break;
                    case "6":

                        if (p6.Equals(" "))
                        {
                            p6 = fichaActual;
                        }
                        else
                        {
                           
                            cambiarJugador = false;
                        }
                        break;
                    case "7":

                        if (p7.Equals(" "))
                        {
                            p7 = fichaActual;
                        }
                        else
                        {
                            
                            cambiarJugador = false;
                        }
                        break;
                    case "8":

                        if (p8.Equals(" "))
                        {
                            p8 = fichaActual;
                        }
                        else
                        {
                            
                            cambiarJugador = false;
                        }
                        break;
                    case "9":

                        if (p9.Equals(" "))
                        {
                            p9 = fichaActual;
                        }
                        else
                        {
                            
                            cambiarJugador = false;
                        }
                        break;

                    default:
                        Console.WriteLine("El dato ingresado no es una posicion valida");
                        break;
                }
                if (cambiarJugador) { //si se cambia de jugador entonces que se muestre el tablero con los ultimos ingresos
                    tablero = ($"╔═╦═╦═╗" +
                        $"\n║{p7}║{p8}║{p9}║" +
                        $"\n╠═╠═╠═╣" +
                        $"\n║{p4}║{p5}║{p6}║" +
                        $"\n╠═╠═╠═╣" +
                        $"\n║{p1}║{p2}║{p3}║" +
                        $"\n╚═╩═╩═╝");
                    Contador++;
                    if (Contador == 9)
                    {
                        hayGanador = true;
                     }

                    jugadorEnTurno = jugadorEnTurno.Equals(nombreJ1) ? nombreJ2 : nombreJ1;
                    Console.WriteLine(tablero);

                }
                else
                {
                    Console.WriteLine("La posicion esta ocupada\nIntente de nuevo");
                }
                    // Console.Clear();


                    Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                Console.ReadKey();
            }


            
        }
    }
}
