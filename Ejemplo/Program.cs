using System;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona p = new Persona("Pepito Flores", 67);

            // Pepito cobra la jubilacion
            p.cobrar(8000);

            // Pepito paga Netflix
            p.pagar(500);

            // Muestra el saldo restante de pepito
            p.verSaldo();

            Persona j = new Persona("Jorge Rodriguez", 30);

            // Jorge hace ejercicio gastando 70 de energia
            j.hacerEjercicio(70);

            // Jorge duerme un par de horas recuperando 30 de energia
            j.dormir(30);

            // Muestra la energia de Jorge
            j.verEnergia();

            // Esto hace que no se cierra la consola para poder leer lo que se imprime
            Console.ReadLine();

        }
    }
}
