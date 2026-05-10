using System;

namespace Totito_Programacion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*para el strTablero
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
            String strPosicion;
            String strTablero, strPosicion1 = " ", strPosicion2 = " ", strPosicion3 = " ", strPosicion4 = " ", strPosicion5 = " ", strPosicion6 = " ", strPosicion7 = " ", strPosicion8 = " ", strPosicion9 = " ";
            String strFichaActual, strJugador1 = "X", strJugador2 = "O";
            String strNombreJugador1 = "Player 1", strNombreJugador2 = "Player 2";
            String strJugadorEnTurno;
            int intContador = 1; //cuando el contador llegue a 9 o hay ganador o hay empate
            Boolean boolHayGanador = false;
            Boolean boolCambiarJugador=false;

            //datos de los jugadores
            Console.WriteLine("Ingrese el nombre del primer jugador");
            strNombreJugador1 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del segundo jugador");
            strNombreJugador2 = Console.ReadLine();

            strJugadorEnTurno = strNombreJugador1;

            while (!boolHayGanador || intContador<=9)
            {
                Console.Clear();
                //Marcar la ficha que esta en juego strJugador1 = X strJugador2 = O
                strFichaActual = strJugadorEnTurno.Equals(strNombreJugador1) ? strJugador1 : strJugador2;

                Console.WriteLine($"Es el turno de {strJugadorEnTurno}");

                strPosicion = Console.ReadLine();

                switch (strPosicion)
                {
                    case "1":

                        if (strPosicion1.Equals(" "))
                        {
                            strPosicion1 = strFichaActual;
                            boolCambiarJugador = true;
                        }
                        else
                        {

                            boolCambiarJugador = false;
                            boolCambiarJugador = true;
                        }
                        break;
                    case "2":

                        if (strPosicion2.Equals(" "))
                        {
                            strPosicion2 = strFichaActual;
                            boolCambiarJugador = true;
                        }
                        else
                        {

                            boolCambiarJugador = false;
                        }
                        break;
                    case "3":

                        if (strPosicion3.Equals(" "))
                        {
                            strPosicion3 = strFichaActual;
                            boolCambiarJugador = true;
                        }
                        else
                        {

                            boolCambiarJugador = false;
                        }
                        break;
                    case "4":

                        if (strPosicion4.Equals(" "))
                        {
                            strPosicion4 = strFichaActual;
                            boolCambiarJugador = true;
                        }
                        else
                        {

                            boolCambiarJugador = false;
                        }
                        break;
                    case "5":

                        if (strPosicion5.Equals(" "))
                        {
                            strPosicion5 = strFichaActual;
                            boolCambiarJugador = true;
                        }
                        else
                        {

                            boolCambiarJugador = false;
                        }
                        break;
                    case "6":

                        if (strPosicion6.Equals(" "))
                        {
                            strPosicion6 = strFichaActual;
                            boolCambiarJugador = true;
                        }
                        else
                        {

                            boolCambiarJugador = false;
                        }
                        break;
                    case "7":

                        if (strPosicion7.Equals(" "))
                        {
                            strPosicion7 = strFichaActual;
                            boolCambiarJugador = true;
                        }
                        else
                        {

                            boolCambiarJugador = false;
                        }
                        break;
                    case "8":

                        if (strPosicion8.Equals(" "))
                        {
                            strPosicion8 = strFichaActual;
                            boolCambiarJugador = true;
                        }
                        else
                        {

                            boolCambiarJugador = false;
                        }
                        break;
                    case "9":

                        if (strPosicion9.Equals(" "))
                        {
                            strPosicion9 = strFichaActual;
                            boolCambiarJugador = true;
                        }
                        else
                        {

                            boolCambiarJugador = false;
                        }
                        break;

                    default:
                        Console.WriteLine("El dato ingresado no es una strPosicion valida");
                        break;
                }

                if (boolCambiarJugador)
                { //si se cambia de jugador entonces que se muestre el strTablero con los ultimos ingresos
                    strTablero = ($"╔═╦═╦═╗" +
                        $"\n║{strPosicion7}║{strPosicion8}║{strPosicion9}║" +
                        $"\n╠═╠═╠═╣" +
                        $"\n║{strPosicion4}║{strPosicion5}║{strPosicion6}║" +
                        $"\n╠═╠═╠═╣" +
                        $"\n║{strPosicion1}║{strPosicion2}║{strPosicion3}║" +
                        $"\n╚═╩═╩═╝");
                    intContador++;

                    strJugadorEnTurno = strJugadorEnTurno.Equals(strNombreJugador1) ? strNombreJugador2 : strNombreJugador1;
                    Console.WriteLine(strTablero);

                }
                else
                {
                    Console.WriteLine("La Posicion ingresada no es valida\nIntente de nuevo");
                }
                


                Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                Console.ReadKey();
            }



        }
    }
}
