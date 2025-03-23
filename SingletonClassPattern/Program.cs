using SingletonClassPattern.MathLibrary;

class main
{
    public static void Main(string[] args)
    {
        Factorial fac = Factorial.GetInstance();
        System.Console.WriteLine(fac.GetFactorial(5));
        System.Console.WriteLine(fac.GetFactorial(10));
        System.Console.WriteLine(fac.GetFactorial(15));
    }
    
}