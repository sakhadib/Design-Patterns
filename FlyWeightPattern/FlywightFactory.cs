namespace FlyWeightPattern;

public static class FlywightFactory
{
    // Create the only instance of BulletFlyweight
    private static BulletFlyweight _bulletFlyweight = new BulletFlyweight("bullet.png", "treble.wav");
    
    public static Bullet getBullet(string type, string color, int size)
    {
        // Create a new Bullet object with the shared BulletFlyweight instance
        return new Bullet(type, color, size, _bulletFlyweight);
    }
}