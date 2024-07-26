// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de la clase OperacionesImpresion
        double radio = 5;
        double altura = 10;
        OperacionesImpresion operaciones = new OperacionesImpresion(radio, altura);

        // Imprimir los resultados
        operaciones.Imprimir();

        // Mantener la consola abierta
        Console.ReadLine();
    }
}

