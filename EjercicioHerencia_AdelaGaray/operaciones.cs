using System;

public class Operaciones
{
    // Método para calcular el área de un círculo
    public double CalcularAreaCirculo(double radio)
    {
        return Math.PI * radio * radio;
    }

    // Método para calcular el volumen de un cilindro
    public double CalcularVolumenCilindro(double radio, double altura)
    {
        return Math.PI * radio * radio * altura;
    }

    // Método para calcular la longitud de una circunferencia
    public double CalcularLongitudCircunferencia(double radio)
    {
        return 2 * Math.PI * radio;
    }
}


