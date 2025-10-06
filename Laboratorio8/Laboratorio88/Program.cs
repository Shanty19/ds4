abstract class ClaseAbstracta
{
    //se fuerza la herencia de la clase para definir estos emetodos
    abstract protected string tomarValor();
    abstract public string prefixValor(string prefix);
    //metodo comun
    public void printOut()
    {
        Console.WriteLine(tomarValor());
    }
}
class ClaseConcreta1 : ClaseAbstracta
{
    protected override string tomarValor()
    {
        return "ClaseConcreta1";
    }
    public override string prefixValor(string prefix)
    {
        return $"{prefix} ClaseConcreta1";
    }
}

class ClaseCroncreta2 : ClaseAbstracta
{
    protected override string tomarValor()
    {
        return "ClaseConcreta2";
    }
    public override string prefixValor(string prefix)
    {
        return $"{prefix} ClaseConcreta2";
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        ClaseConcreta1 concreta1 = new ClaseConcreta1();
        concreta1.printOut();
        Console.WriteLine(concreta1.prefixValor("ES_"));

        ClaseCroncreta2 croncreta2 = new ClaseCroncreta2();
        croncreta2.printOut();
        Console.WriteLine(croncreta2.prefixValor("ES_"));
    }
}