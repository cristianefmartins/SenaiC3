//Exercicio Polimorfismo - Sobrescrita

/*
public class InstrumentoMusical
{
    public virtual void Tocar()
    {
        Console.WriteLine("Tocando o instrumento...");
    }
}


public class Violao : InstrumentoMusical 
{
    public override void Tocar()
    {
        Console.WriteLine("Tocando o violao: strum, strum");
    }

}

public class Piano : InstrumentoMusical
{
    public override void Tocar()
    {
        Console.WriteLine("Tocando o piano: plim, plim");
    }
}
*/

//Exercicio Polimorfismo - Sobrecarga

/*
public class Calculadora
{
    public int Somar(int num1, int num2)
    { 
        return num1 + num2;
    }
    public int Somar(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }

}
*/


//Exercicio Abstracao - contrato
public abstract class FormaGeometrica
{
    public abstract void CalcularArea();

}

//O Quadrado vai ficar em vermelho, ai vc da um CTRL . e escolhe implementar classe abstrata
public class Quadrado : FormaGeometrica
{
    public double Lado;
    public override void CalcularArea()
    {
        Console.WriteLine(Lado * Lado);
    }
}


public class Triangulo : FormaGeometrica
{
    public double Lado;
    public override void CalcularArea()
    {
        Console.WriteLine((Lado * Lado)/2);
    }
}