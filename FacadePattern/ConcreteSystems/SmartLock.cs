namespace FacadePattern.ConcreteSystems;

public class SmartLock
{
    public void LockDoor()
    {
        Console.WriteLine("Locking door");
    }
    
    public void UnlockDoor()
    {
        Console.WriteLine("Unlocking door");
    }
}