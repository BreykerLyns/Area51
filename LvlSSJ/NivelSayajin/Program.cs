using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelSayajin
    {
    class Program
        {
        static void Main(string[] args)
            {
            string stringUsuario;
            int intUsuario = 0;
            int poderSayajin = 0;

            Console.WriteLine("Bienvenido guerrero de clase baja\n");
            Console.WriteLine("================================================");
            Console.WriteLine("Con este programa sabrás si tienes el poder \nde pelea de un insecto, una sabandija o un guerrero Z." + "\n" +
                "Espero que estés listo!\n");
            Console.WriteLine("================================================");
            Console.WriteLine("================================================\n\n");
            Console.WriteLine("Dime, ¿Cuántas veces has intentado hacer el Kame-Hame-Ha?\n");
            Console.WriteLine("1=Nunca.    2=He intentado.    3=Siempre bale.");
            Console.WriteLine();
            Console.Write("Ingrese un número del 1 al 3 :");

            stringUsuario = Console.ReadLine();

            switch (stringUsuario)
                {
                case "1":
                    Console.WriteLine("Interesante, 15 puntos.");
                    poderSayajin = poderSayajin + 15;
                    break;
                case "2":
                    Console.WriteLine("Get a life bro! 35 puntos.");
                    break;
                case "3":
                    Console.WriteLine("kómo lo zupo? 105 puntos.");
                    break;
                }

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("¿Cuál es tu mejor característica?\n");
            Console.WriteLine("1=La fuerza.    2=La inteligencia.    3=La velocidad.");
            Console.WriteLine();
            Console.Write("Ingrese un número del 1 al 3 :");

            stringUsuario = Console.ReadLine();
            switch (stringUsuario)
                {
                case "1":
                    Console.WriteLine("Su nivel de poder es Himplesionanteh, 30 puntos.");
                    break;
                case "2":
                    Console.WriteLine("El conocimiento es poder, 35 puntos.");
                    break;
                case "3":
                    Console.WriteLine("Vuela, pega y esquiva, 105 puntos.");
                    break;

                }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Entonces, si tuvieses un poder lo utilizarías para...?\n");
            Console.WriteLine("1=Conquistar el mundo.    2=Derrotar enemigos.    3=Defender a los debiles.");
            Console.WriteLine();
            Console.Write("Ingrese un número del 1 al 3 :");

            stringUsuario = Console.ReadLine();
            switch (stringUsuario)
                {
                case "1":
                    Console.WriteLine("Eres un dios muy generoso, 15 puntos.");
                    break;
                case "2":
                    Console.WriteLine("Oblígame prro, 35 puntos.");
                    break;
                case "3":
                    Console.WriteLine("YA BASTA FREEZER!, 50 puntos.");
                    break;

                }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("¿De qué forma consideras tu estilo de lucha?\n");
            Console.WriteLine("1=Ataques fuertes pero lentos.    2=Ataques rápidos pero débiles.");
            Console.WriteLine();
            Console.Write("Ingrese un número del 1 al 2 :");


            stringUsuario = Console.ReadLine();
            switch (stringUsuario)
                {
                case "1":
                    Console.WriteLine("Ay chiamo, 10 puntos.");
                    break;
                case "2":
                    Console.WriteLine("Si el agua es vida, ¿por qué se muere ahogado?, 35 puntos.");
                    break;

                }
            Console.WriteLine("\n");

            Console.WriteLine("Si pudieses destruir un planeta, ¿Lo harias?\n");
            Console.WriteLine("1=Claro bb.    2=Ño");
            Console.WriteLine();
            Console.Write("Ingrese un número del 1 al 2 :");

            stringUsuario = Console.ReadLine();

            switch (stringUsuario)
                {
                case "1":
                    Console.WriteLine("ola k ase? hehe, 25 puntos.");
                    break;
                case "2":
                    Console.WriteLine("inserte frase motivacional, 30 puntos.");
                    break;
                }

            Console.WriteLine("\n");

            Console.WriteLine("Ahora que haz terminado puedes sumar los puntos de cada respuesta.");
            Console.WriteLine("Ingrese el número total de los resultados");
            stringUsuario = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("¿Estás listo para saber tu nivel de poder?\n");
            Console.WriteLine("1=Shi.    2=Ño.");
            Console.WriteLine();
            Console.Write("Ingrese un número del 1 al 2 :");

            stringUsuario = Console.ReadLine();
            switch (stringUsuario)
                {
                case "1":
                    Console.WriteLine("Pa' que quieres saber eso? Jaja salu2");
                    break;
                case "2":
                    Console.WriteLine("Weno chau :(");
                    break;


                }
            Console.WriteLine();
            Console.WriteLine();


            //Almaceno lo que ha escrito el usuario en formato caedna de caracteres
            stringUsuario = Console.ReadLine();
            //convierto esa cadena de caracteres en un numero que me sirva
            intUsuario = Convert.ToInt32(stringUsuario);

            //Primera condicional
            //Si el numero ingresado es menor que diez
            if (intUsuario <= 50)
                {
                //Entonces es un marico!
                Console.WriteLine("Tipico de un guerrero de clase baja...");
                //y hago que su numero ingresado sea su nivel de pelea
                poderSayayin = poderSayayin + intUsuario;
                }
            //En esta parte ya descartamos que el numero ingresado es mayor que diez (porque ya salimos de la anterior condición)
            //Ahora evaluamos si es menor que 50
            else if (intUsuario >= 300)
                {
                //Entonces al menos hay salud
                Console.WriteLine("Siempre puede ser peor...");
                //y ahora actualizamos la variable que almacena el nivel de pelea
                poderSayayin = poderSayayin + intUsuario;

                }
            }
        }
    }