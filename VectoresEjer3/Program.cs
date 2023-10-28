using System;

namespace VectoresEjer3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
            //El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo.
            //Mostrar el resultado en pantalla. Ejemplo:CADENA FUENTE: “La mar estaba serena" CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’CADENA RESULTADO: “Li mir estibi sereni"

            // char[] cadena = new char[30];
            // char letraActual;
            // char letraNueva;
            // char letra;
            // int indice = 0;

            // Console.WriteLine("Ingrese una letra: ");
            // letra = char.Parse(Console.ReadLine());
            // while (letra != '0' && indice < 30)
            // {
            //     cadena[indice] = letra;
            //     Console.WriteLine("Ingrese otra letra: ");
            //     letra = char.Parse(Console.ReadLine());
            //     indice++;
            // }
            // cadena[indice] = '\0';
            // Console.WriteLine("la frase completa es: ");
            // indice = 0;
            // while (cadena[indice] != '\0')
            // {
            //     Console.Write(cadena[indice]);
            //     indice++;                
            // }
            // Console.WriteLine(" Ingrese letra a reemplazar");
            // letraActual = char.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese otra letra");
            // letraNueva = char.Parse(Console.ReadLine());

            // indice = 0;
            // while (cadena[indice] != '\0')
            // {
            //     if (cadena[indice] == letraActual)
            //         cadena[indice] = letraNueva;

            //         indice++;
            // }
            // Console.WriteLine("La frase nueva es: ");
            // indice = 0;
            // while (cadena[indice] != '\0')
            // {
            //     Console.Write(cadena[indice]);
            //     indice++;
            
            string frase;
            char letraActual;
            char letraNueva;
            Console.WriteLine("Ingrese la frase: ");
            frase = Console.ReadLine();
            Console.WriteLine("Ingrese la letra a reemplazar");
            letraActual = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nueva letra");
            letraNueva = char.Parse(Console.ReadLine());

            frase = frase.Replace(letraActual, letraNueva);

            Console.WriteLine("La cadena nueva es: ");
            Console.WriteLine(frase);
            
        }
    }
}
