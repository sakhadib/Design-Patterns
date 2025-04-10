namespace FlyWeightPattern;

public class Bullet
{
    public string Type { get; }
    public string Color { get; }
    public int Size { get; }
    
    public BulletFlyweight BulletFlyweight { get; }

    public Bullet(string type, string color, int size, BulletFlyweight bulletFlyweight)
    {
        BulletFlyweight = bulletFlyweight;
        Type = type;
        Color = color;
        Size = size;
    }
    
    public void Fire()
    {
        Console.WriteLine($"Firing a {Color} {Type} bullet of size {Size} {BulletFlyweight.Fire()}");
    }
}