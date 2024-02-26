namespace ActividadAsincronaS06
{
    public class Program
    {
        static int[] numeros = { 100, 30, 40, 51, 65, 72, 96, 111, 160, 18, 20 };
        //creacion de una lista no es igual al arraylist
        static List<string> nombres = new() { "Francisco", "Marlon", "Tatiana", "Marisol", "ana", "Miguel", "Oscar","Aaron" };

        static void Main(string[] args)
        {
            
            //FiltraPorletraACominezo();
            FiltarNumerosMayores50();


        }

        static void FiltraPorletraACominezo()
        {

            //Filtrar nombres que Comienzen con la letra  "A"

            //Funcion LINQ
            var filtro = from nombre in nombres
                         where nombre.StartsWith('a') | nombre.StartsWith('A')
                         select nombre;
            Console.WriteLine("---------------------------------------");
            foreach (var item in filtro) { 
                
                Console.WriteLine(item);    

            }
            Console.WriteLine("---------------------------------------");

            var filtro2 = nombres.Where(nombre => nombre.StartsWith('a') | nombre.StartsWith('A')); //la condion or la utilizo por si en la lista hay dos nombres pero uno inicia 
                                                                                                    //con minuscula y el otro mayuscula        
            foreach (var nombre in filtro2)
            {
                Console.WriteLine($"{nombre}");
            }


        }

        static void FiltarNumerosMayores50()
        {
            //Filtrar numero mayores a 50
            // Funcion LINQ

            var filtro = from numero in numeros //             //
                         where numero > 50      // Funcion LINQ//
                         select numero;         //             //

            Console.WriteLine("LinQ\n"+"Los numeros mayores a 50 son: " + string.Join(", ", filtro));

            //Funcion LAMBDA

            var filtro2 = numeros.Where(x => x > 50);
            Console.WriteLine("LAMBDA\n" + "Los numeros mayores a 50 son: " + string.Join(", ", filtro2));


        }



        
        }
    }
