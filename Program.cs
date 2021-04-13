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
                    o	C) La asignación de una orden a un operador. Para ello, el usuario indicará un número de operador y el sistema le asignará la próxima orden de trabajo no asignada, teniendo en cuenta el orden de carga del punto A), dando por terminada la asignación anterior en caso de existir una. Este proceso se repetirá tantas veces como indique el usuario.
                    o	D) Al terminar, reporte: cuántas órdenes cumplió cada operador, qué órdenes quedaron pendientes de asignar.

            */
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            List<string> operarios = new List<string>();
            List<string> nOrden = new List<string>();
            //Dictionary<int, string> operarios = new Dictionary<int, string>();
            //Dictionary<int, string> nOrdenes = new Dictionary<int, string>();
            //FiFo first in first out.
            Queue<int> colaDeOrdenes = new Queue<int>();
            int idO = 1, idOt = 1;

            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Añadir un operador");
            Console.WriteLine("2) Añadir una orden de trabajo");
            Console.WriteLine("3) Asignar orden a operador");
            Console.WriteLine("4) Ver reporte");
            Console.WriteLine("5) Ver reporte");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    
                    return true;
                case "2":
                    
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        class operario
        { 
        
        
        }







        /*
                    do
                    {

                        Console.WriteLine($"Por favor ingrese el operario {colaDeOrdenes.Count}, deje vacio para continuar: ");
                        string nombre = Console.ReadLine();
                        if (nombre == "")
                        {
                            break;
                        }
                        operarios.Add(nombre);
                    } while (true);

                    do
                    {


                        Console.WriteLine($"Por favor ingrese el numero de orden {nOrden.Count}, deje vacio para continuar: ");
                        string orden = Console.ReadLine();
                        if (orden == "")
                        {
                            break;
                        }
                        int norden;
                        bool nDeOrden = int.TryParse(orden, out norden);
                        if (!nDeOrden)
                        {
                            break;
                        }
                        colaDeOrdenes.Enqueue(norden);
                    } while (true);

        */




                    /* Tire error si no existe

                     try
        {
            Console.WriteLine("For key = \"tif\", value = {0}.",
                openWith["tif"]);
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine("Key = \"tif\" is not found.");
        }

                     */

                    //Console.WriteLine("Saliste");
                    //Console.ReadKey();



            }

        }

