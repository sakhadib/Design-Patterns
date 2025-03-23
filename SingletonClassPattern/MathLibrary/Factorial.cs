namespace SingletonClassPattern.MathLibrary;

public class Factorial
{
    private static Factorial _instance;
    private long[] _factorialCache;
    private Factorial()
    {
        preComputeFactorials(120);
    }
    
    public static Factorial GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Factorial();
        }
        return _instance;
    }
    
    private void preComputeFactorials(int n)
    {
        _factorialCache = new long[n + 1];
        _factorialCache[0] = 1;
        for (int i = 1; i <= n; i++)
        {
            _factorialCache[i] = _factorialCache[i - 1] * i;
        }
    }
    
    public long GetFactorial(int n)
    {
        return _factorialCache[n];
    }
    
    
}