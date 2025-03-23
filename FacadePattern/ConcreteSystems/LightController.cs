namespace FacadePattern.ConcreteSystems;

public class LightController
{
    public void SetBrightness(int brightness)
    {
        Console.WriteLine($"Setting light brightness to {brightness}");
    }
    
    public void SetColor(string color)
    {
        Console.WriteLine($"Setting light color to {color}");
    }
}