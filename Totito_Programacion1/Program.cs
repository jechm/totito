using Microsoft.Win32;
using System;
using System.Security.Cryptography;

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
            int intPosicionIngresada = 0;

            String[] strPosiciones = { " ", " ", " ", " ", " ", " ", " ", " ", " " };
            String strFichaActual, strJugador1 = "X", strJugador2 = "O";
            String strNombreJugador1 = "Player 1", strNombreJugador2 = "Player 2";
            String strJugadorEnTurno;
            int intContador = 1; //cuando el contador llegue a 9 o hay ganador o hay empate
            Boolean boolHayGanador = false;
            Boolean boolCambiarJugador = false;


            //datos de los jugadores
            Console.WriteLine("Ingrese el nombre del primer jugador");
            strNombreJugador1 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del segundo jugador");
            strNombreJugador2 = Console.ReadLine();

            strJugadorEnTurno = strNombreJugador1;

            while (!boolHayGanador && intContador <= 9)
            {

                //Marcar la ficha que esta en juego strJugador1 = X strJugador2 = O
                strFichaActual = strJugadorEnTurno.Equals(strNombreJugador1) ? strJugador1 : strJugador2;

                Console.WriteLine($"Es el turno de {strJugadorEnTurno}");

                intPosicionIngresada = ObtenerPosicionIngresada();

                //verifica si la posicion esta ocupada si la posicion no esta ocupada entonces se pude cambiar de jugador por lo tanto se escribe en el tablero
                //y el contador de turnos aumenta en 1
                boolCambiarJugador = intPosicionIngresada > 0 && intPosicionIngresada <= 9 && strPosiciones[intPosicionIngresada - 1].Equals(" ");


                if (boolCambiarJugador)
                { //si se cambia de jugador entonces que se muestre el strTablero con los ultimos ingresos

                    strPosiciones[intPosicionIngresada - 1] = strFichaActual;
                    MostrarTablero(strPosiciones);

                    boolHayGanador = verificarGanador(strPosiciones);
                    intContador++;
                    if (!boolHayGanador)
                    {
                        strJugadorEnTurno = strJugadorEnTurno.Equals(strNombreJugador1) ? strNombreJugador2 : strNombreJugador1;
                    }

                }
                else
                {
                    Console.WriteLine("La Posicion ingresada no es valida\nIntente de nuevo");
                }



                Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                Console.ReadKey();
            }


            if (!boolHayGanador)
            {
                Console.WriteLine("EL PARTIDO TERMINO EN EMPATE");
            }
            else
            {
                Console.WriteLine($"El ganador es: {strJugadorEnTurno}");
            }
            Console.ReadKey();



        }

        static bool verificarGanador(string[] strPosiciones)
        {
            /*hay 8 formas de que alguien gane
             * 3 en horizontal 
             * 3 en vertical
             * 2 en diagonal
             */
            Boolean boolHayGanador, boolGanadorHorizontal, boolGanadorVertical, boolGanadorDiagonal;

            boolGanadorHorizontal = comparaPosiciones(strPosiciones, 0, 1, 2) || comparaPosiciones(strPosiciones, 3, 4, 5) || comparaPosiciones(strPosiciones, 6, 7, 8);
            boolGanadorVertical = comparaPosiciones(strPosiciones, 0, 3, 6) || comparaPosiciones(strPosiciones, 1, 4, 7) || comparaPosiciones(strPosiciones, 2, 5, 8);
            boolGanadorDiagonal = comparaPosiciones(strPosiciones, 6, 4, 2) || comparaPosiciones(strPosiciones, 0, 4, 8);


            boolHayGanador = boolGanadorHorizontal || boolGanadorVertical || boolGanadorDiagonal;
            return boolHayGanador;
        }

        //funcion cuyo objetivo es recibir 3 posiciones y verificar si el valor indicado es igual entre ellas
        //primero se prueba que la posicion 1 no este vacia luego se comparan las otras 3 si se cumple todo entonces el resutado es que hay ganador
        static bool comparaPosiciones(string[] strPosiciones, int posicion1, int posicion2, int posicion3) {
            return !strPosiciones[posicion1].Equals(" ") && strPosiciones[posicion1].Equals(strPosiciones[posicion2]) && strPosiciones[posicion1].Equals(strPosiciones[posicion3]);

        }



        //Funcion que muestra el tablero en pantalla
        static void MostrarTablero(String[] posiciones)
        {
            String strTablero;

            Console.Clear();

            strTablero = ($"╔═╦═╦═╗" +
    $"\n║{posiciones[6]}║{posiciones[7]}║{posiciones[8]}║" +
    $"\n╠═╠═╠═╣" +
    $"\n║{posiciones[3]}║{posiciones[4]}║{posiciones[5]}║" +
    $"\n╠═╠═╠═╣" +
    $"\n║{posiciones[0]}║{posiciones[1]}║{posiciones[2]}║" +
    $"\n╚═╩═╩═╝");

            Console.WriteLine(strTablero);
        }

        //Procesa el ingreso de la posicion deseada
        //Si se ingresa un valor incorrecto entonces devuelve -1 para indicar un valor invalido
        static int ObtenerPosicionIngresada()
        {

            String strValorIngresado = "";
            int posicion = -1;

            strValorIngresado = Console.ReadLine();

            try
            {
                posicion = Convert.ToInt32(strValorIngresado.Trim());
            }
            catch (Exception e)
            {
                Console.WriteLine("El valor ingresado no es valido");
                posicion = -1;
            }

            return posicion;
        }
    

            
        
    }
}

//a = Console.ReadKey.keychar