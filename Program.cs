﻿using System;
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

            List<string> operarios = new List<string>();
            List<int> oRoperarios = new List<int>();
            List<int> colaDeOrdenes = new List<int>();
            List<int> oRcolaDeOrdenes = new List<int>();
            int[] auxiliar = new int[2];
            string nombre;
            int flag = 0;
            int norden, operador;
            int auxOperarios = -1;
            double auxcolaDeOrdenes = -1;
            bool nDeOrden;
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
                            flag = 1;
                            Console.WriteLine($"Por favor ingrese el operario Nª {operarios.Count}, deje vacio para salir: ");
                            nombre = Console.ReadLine();
                            if (nombre == "")
                            {
                                flag = 0;
                                break;
                            }

                            for (int i = 0; i < operarios.Count; i++)
                            {
                                if (nombre == operarios[i])
                                {
                                    Console.WriteLine($"Ese operario se encuentra cargado, por favor seleccione otro. ");
                                    flag = 0;


                                }
                            }

                            if (flag == 1)
                            {
                                operarios.Add(nombre);
                                oRoperarios.Add(0);
                            }


                        } while (true);
                        break;


                    case "2":
                        do
                        {
                            flag = 1;
                            Console.WriteLine($"Por favor ingrese el numero de orden {colaDeOrdenes.Count}, deje vacio para salir: ");
                            string orden = Console.ReadLine();
                            if (orden == "")
                            {
                                flag = 0;
                                break;
                            }
                            nDeOrden = int.TryParse(orden, out norden);
                            if (!nDeOrden)
                            {
                                Console.WriteLine($"Ingrese un numero por favor. ");
                                flag = 0;
                            }
                            if (nDeOrden)
                                for (int i = 0; i < colaDeOrdenes.Count; i++)
                                {
                                    if (norden == colaDeOrdenes[i])
                                    {
                                        Console.WriteLine($"Ese operario se encuentra cargado, por favor seleccione otro. ");
                                        flag = 0;


                                    }
                                }

                            if (flag == 1)
                            {
                                colaDeOrdenes.Add(norden);
                                oRcolaDeOrdenes.Add(0);
                            }
                        } while (true);
                        break;


                    case "3":
                        flag = 0;
                        if (operarios.Count == 0)
                        {
                            Console.WriteLine($"No hay ningun operador cargado, primero cargue uno por favor.");
                            Console.ReadKey();
                            break;
                        }
                        do
                        {
                            Console.WriteLine($"Por favor elija uno de estos operarios para asignarles una orden trabajo: ");
                            for (int i = 0; i < operarios.Count; i++)
                            {
                                Console.WriteLine($"{operarios[i]} nª {i}, y realizó {oRoperarios[i]} OdT hasta ahora. ");
                            }

                            string numeroOperador = Console.ReadLine();
                            bool nOperador = int.TryParse(numeroOperador, out operador);

                            if (operador <= operarios.Count)
                            {
                                flag = 1;
                            }

                        } while (flag == 0);

                        //Cree dos listas extras para guardar los valores de oRcolaDeOrdenes si fue o no asignada, si el valor es 0, no fue asignada
                        //Hay dos variables auxiliares que solo guardan si hay una orden trabajandose y por quien. auxOperarios, auxcolaDeOrdenes
                        if (auxcolaDeOrdenes == -1 && auxOperarios == -1)
                        {
                            operador = auxOperarios;


                        }




                        break;
                    case "4":


                        break;
                    case "5":
                        Console.WriteLine($"Tenemos {operarios.Count} operarios y {colaDeOrdenes.Count} ordenes de trabajo");
                        for (int i = 0; i < operarios.Count; i++)
                        {
                            Console.WriteLine($"El operario {operarios[i]} realizó {oRoperarios[i]}. ");
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

