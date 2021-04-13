using System;
using System.Collections.Generic;


namespace A875490.Actividad02
{
    class Program
    {



        static void Main(string[] args)
        {
            /*
             * 
             *      -	Complete la codificación del ejercicio que se propone más abajo y compártala en un repositorio público de GitHub llamado “A[NroRegistro].Actividad02”
                    -	Complete el formulario indicando número de registro y usuario (no del repositorio, que debe ser, en cualquier caso, el indicado arriba) en github: Vínculo al formulario
                    -	Vínculo al formulario en texto plano: https://forms.office.com/Pages/ResponsePage.aspx?id=eY-BTISrUkWbfC_nFbDQ1TKuCrTwNtVHvHonU8CCmaBURjFVOUtYUDlENVJVSUNYSkhaQTJCUlZXMy4u

                * -	Una empresa de cable necesita una aplicación para encolar las órdenes de instalación recibidas y asignarlas a los técnicos que las realizarán. Para ello se le solicita una aplicación que permita:
                    o	A) El ingreso de una cantidad de operadores (identificados por un número de operador).
                    o	B) El ingreso de una cantidad de órdenes de trabajo (identificadas por un número de órden).
                    o	C) La asignación de una orden a un operador. Para ello, el usuario indicará un número de operador y el sistema le asignará la próxima orden de trabajo no asignada, teniendo en cuenta el orden de carga del punto A),
                        dando por terminada la asignación anterior en caso de existir una. Este proceso se repetirá tantas veces como indique el usuario.
                    o	D) Al terminar, reporte: cuántas órdenes cumplió cada operador, qué órdenes quedaron pendientes de asignar.

            */

            //List<string> operarios = new List<string>();
            Dictionary<int, int> operarios = new Dictionary<int, int>();
            Queue<int> colaDeOrdenes = new Queue<int>();
            int[] auxiliar = new int[2] { -1, -1 };
            string aux = "0";
            //bool nOperario;
            do
            {

                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Añadir un operador");
                Console.WriteLine("2) Añadir una orden de trabajo");
                Console.WriteLine("3) Asignar orden a operador");
                Console.WriteLine("4) Ver reporte");
                Console.WriteLine("5) Ver todo lo cargado");
                Console.WriteLine("6) Salir");
                Console.Write("\r\nSelect an option: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        do
                        {
                            int flags = 1;
                            Console.WriteLine($"Por favor ingrese el numero del operario, deje vacio para salir: ");
                            string nombre = Console.ReadLine();
                            if (nombre == "")
                            {
                                flags = 0;
                                break;
                            }
                            bool nOperario = int.TryParse(nombre, out int operador);
                            if (!nOperario)
                            {
                                flags = 0;
                                Console.WriteLine("Solo ingrese numeros por favor.");
                            }

                            bool existeOp = operarios.ContainsKey(operador);

                            if (existeOp)
                            {
                                flags = 0;
                                Console.WriteLine($"Ese operario se encuentra cargado, por favor seleccione otro. ");
                            }



                            if (flags == 1)
                            {
                                operarios.Add(operador, 0);


                            }


                        } while (true);
                        break;


                    case "2":
                        do
                        {
                            int flags = 1;
                            Console.WriteLine($"Por favor ingrese el numero de orden, deje vacio para salir: ");
                            string orden = Console.ReadLine();
                            if (orden == "")
                            {
                                flags = 0;
                                break;
                            }
                            bool nDeOrden = int.TryParse(orden, out int norden);
                            if (!nDeOrden)
                            {
                                Console.WriteLine($"Ingrese un numero por favor. ");
                                flags = 0;
                            }

                            bool existeNo = colaDeOrdenes.Contains(norden);

                            if (existeNo)
                            {
                                flags = 0;
                                Console.WriteLine($"Esta orden ya se encuentra cargada, por favor intente con otra. ");
                            }

                            if (flags == 1)
                            {
                                colaDeOrdenes.Enqueue(norden);

                            }
                        } while (true);
                        break;


                    case "3":
                        do
                        {
                            int flags = 0;
                            if (operarios.Count == 0)
                            {
                                Console.WriteLine($"No hay ningun operador cargado, primero cargue uno por favor.");
                                Console.ReadKey();
                                break;
                            }
                            if (colaDeOrdenes.Count == 0)
                            {
                                Console.WriteLine($"No hay ninguna orden cargada, primero cargue una por favor.");
                                Console.ReadKey();
                                break;
                            }
                            bool existeOp = false;
                            int operador;
                            do
                            {


                                Console.WriteLine($"Por favor elija uno de estos operarios para asignarles una orden trabajo: ");
                                foreach (KeyValuePair<int, int> operario in operarios)
                                {
                                    Console.WriteLine($"Operario {operario.Key}, y realizó {operario.Value} OdT hasta ahora. ");
                                }



                                string numeroOperario = Console.ReadLine();
                                bool nOperador = int.TryParse(numeroOperario, out operador);
                                if (!nOperador)
                                {
                                    Console.WriteLine("Por favor ingrese solo numeros");
                                    flags = 0;
                                }

                                existeOp = operarios.ContainsKey(operador);

                                if (!existeOp)
                                {
                                    Console.WriteLine("No existe el operador seleccionado");
                                }

                            } while (existeOp == false);

                            bool existeOdT = false;
                            int nCola;


                            do
                            {
                                Console.WriteLine($"Por favor elija una de estas ordenes de trabajo: ");

                                foreach (var cola in colaDeOrdenes)
                                {
                                    Console.WriteLine($"{cola}");
                                }

                                string numeroOrden = Console.ReadLine();

                                bool odt = int.TryParse(numeroOrden, out nCola);
                                if (!odt)
                                {
                                    Console.WriteLine("Por favor ingrese solo numeros");
                                    flags = 0;
                                }

                                existeOdT = colaDeOrdenes.Contains(nCola);
                                if (!existeOdT)
                                {
                                    Console.WriteLine("No existe la orden seleccionada");

                                }


                            } while (existeOdT == false);






                            if (auxiliar[0] == -1)
                            {
                                auxiliar[0] = operador;
                                auxiliar[1] = colaDeOrdenes.Dequeue();

                            }
                            else if (auxiliar[0] >= 0)
                            {                         
                            
                                operarios[auxiliar[0]] = 1;
                                auxiliar[1] = colaDeOrdenes.Dequeue();
                                auxiliar[0] = operador;
                            }



                        } while (true);





                        //Cree dos listas extras para guardar los valores de oRcolaDeOrdenes si fue o no asignada, si el valor es 0, no fue asignada
                        //Hay dos variables auxiliares que solo guardan si hay una orden trabajandose y por quien. auxOperarios, auxcolaDeOrdenes




                        break;
                    case "4":


                        break;
                    case "5":
                        Console.WriteLine($"Tenemos {operarios.Count} operarios y {colaDeOrdenes.Count} ordenes de trabajo");
                        foreach (KeyValuePair<int, int> operario in operarios)
                        {
                            Console.WriteLine($"Estan cargados el operarios Nª{operario.Key} y realizó {operario.Value} oDt ");
                        }

                        Console.ReadKey();
                        break;
                    case "6":
                        return;
                    default:
                        break;
                }
            } while (true);




        }



    }


}

