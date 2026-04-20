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

            //datos de los jugadores
            Console.WriteLine("Ingrese el nombre del primer jugador");
            nombreJ1 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del segundo jugador");
            nombreJ2 = Console.ReadLine();

            jugadorEnTurno = nombreJ1;

            //Marcar la ficha que esta en juego j1 = X j2 = O
            fichaActual = jugadorEnTurno.Equals(nombreJ1) ? j1 : j2;

            Console.WriteLine($"ingrese la posicion n para el jugador {jugadorEnTurno}");

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
                        Console.WriteLine("La posicion esta ocupada\nIntente de nuevo");
                    }
                    break;
                case "2":

                    if (p1.Equals(" "))
                    {
                        p1 = fichaActual;
                    }
                    else
                    {
                        Console.WriteLine("La posicion esta ocupada\nIntente de nuevo");
                    }
                    break;
                case "3":

                    if (p1.Equals(" "))
                    {
                        p1 = fichaActual;
                    }
                    else
                    {
                        Console.WriteLine("La posicion esta ocupada\nIntente de nuevo");
                    }
                    break;
                case "4":

                    if (p1.Equals(" "))
                    {
                        p1 = fichaActual;
                    }
                    else
                    {
                        Console.WriteLine("La posicion esta ocupada\nIntente de nuevo");
                    }
                    break;
                case "5":

                    if (p1.Equals(" "))
                    {
                        p1 = fichaActual;
                    }
                    else
                    {
                        Console.WriteLine("La posicion esta ocupada\nIntente de nuevo");
                    }
                    break;
                case "6":

                    if (p1.Equals(" "))
                    {
                        p1 = fichaActual;
                    }
                    else
                    {
                        Console.WriteLine("La posicion esta ocupada\nIntente de nuevo");
                    }
                    break;
                case "7":

                    if (p1.Equals(" "))
                    {
                        p1 = fichaActual;
                    }
                    else
                    {
                        Console.WriteLine("La posicion esta ocupada\nIntente de nuevo");
                    }
                    break;
                case "8":

                    if (p1.Equals(" "))
                    {
                        p1 = fichaActual;
                    }
                    else
                    {
                        Console.WriteLine("La posicion esta ocupada\nIntente de nuevo");
                    }
                    break;
                case "9":

                    if (p1.Equals(" "))
                    {
                        p1 = fichaActual;
                    }
                    else
                    {
                        Console.WriteLine("La posicion esta ocupada\nIntente de nuevo");
                    }
                    break;

                default:
                    Console.WriteLine("El dato ingresado no es una posicion valida");
                    break;
            }
            
            tablero = ($"╔═╦═╦═╗" +
                $"\n║{p7}║{p8}║{p9}║" +
                $"\n╠═╠═╠═╣" +
                $"\n║{p4}║{p5}║{p6}║" +
                $"\n╠═╠═╠═╣" +
                $"\n║{p1}║{p2}║{p3}║" +
                $"\n╚═╩═╩═╝");

            Console.WriteLine(tablero);

            jugadorEnTurno = jugadorEnTurno.Equals(nombreJ1) ? nombreJ2 : nombreJ1;


            Console.Clear();
        }
    }
}
