using FlyWeightPattern;

class main
{
    public static void Main(string[] args)
    {
        Bullet bullet = FlywightFactory.getBullet("normal", "red", 10);
        bullet.Fire();
    }
}

// Output:
// Firing a red normal bullet of size 10 with sprite bullet.png and treble treble.wav