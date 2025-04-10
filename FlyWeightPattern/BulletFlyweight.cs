namespace FlyWeightPattern;

public class BulletFlyweight
{
    public string Sprite { get; }
    public string Treble { get; }
    
    public BulletFlyweight(string sprite, string treble)
    {
        Sprite = sprite;
        Treble = treble;
    }
    
    public string Fire()
    {
        return $"with sprite {Sprite} and treble {Treble}";
    }
    
}