using System;

public class OperacionesImpresion : Operaciones
{
    private double _radio;
    private double _altura;

    // Constructor ///
    public OperacionesImpresion(double radio, double altura = 0)
    {
        _radio = radio;
        _altura = altura;
    }

    // Método para imprimir resultados /// 
    public void Imprimir()
    {
        Console.WriteLine($"Área del círculo con radio {_radio}: {CalcularAreaCirculo(_radio)}");
        Console.WriteLine($"Volumen del cilindro con radio {_radio} y altura {_altura}: {CalcularVolumenCilindro(_radio, _altura)}");
        Console.WriteLine($"Longitud de la circunferencia con radio {_radio}: {CalcularLongitudCircunferencia(_radio)}");
    }
}
