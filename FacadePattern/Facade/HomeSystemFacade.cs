using FacadePattern.ConcreteSystems;

namespace FacadePattern.Facade;

public class HomeSystemFacade
{
    private readonly EnvironmentSystem _environmentSystem;
    private readonly SecurityCamera _securityCamera;
    private readonly SmartLock _smartLock;
    private readonly TemparatureController _temparatureController;
    private readonly LightController _lightSystem;
    
    public HomeSystemFacade(EnvironmentSystem environmentSystem, SecurityCamera securityCamera, SmartLock smartLock, TemparatureController temparatureController, LightController lightSystem)
    {
        _environmentSystem = environmentSystem;
        _securityCamera = securityCamera;
        _smartLock = smartLock;
        _temparatureController = temparatureController;
        _lightSystem = lightSystem;
    }
    
    public void StartMovieMode()
    {
        _environmentSystem.StartMovieMode();
        _securityCamera.ActivateSecurityCamera();
        _smartLock.LockDoor();
        _temparatureController.setTemparature(20);
        _lightSystem.SetBrightness(30);
    }
    
    public void StopMovieMode()
    {
        _environmentSystem.StopMovieMode();
        _securityCamera.DeactivateSecurityCamera();
        _smartLock.UnlockDoor();
        _temparatureController.setTemparature(25);
        _lightSystem.SetBrightness(100);
    }
    
    public void SetTemparature(int temparature)
    {
        _temparatureController.setTemparature(temparature);
    }
    
    public void SetBrightness(int brightness)
    {
        _lightSystem.SetBrightness(brightness);
    }
    
    public void SetColor(string color)
    {
        _lightSystem.SetColor(color);
    }
    
    public void LockDoor()
    {
        _smartLock.LockDoor();
    }
    
    public void UnlockDoor()
    {
        _smartLock.UnlockDoor();
    }
    
    public void ActivateSecurityCamera()
    {
        _securityCamera.ActivateSecurityCamera();
    }
    
    public void DeactivateSecurityCamera()
    {
        _securityCamera.DeactivateSecurityCamera();
    }
    
    public void StartPartyMode()
    {
        _lightSystem.SetBrightness(100);
        _lightSystem.SetColor("RGB");
    }
    
    public void StopPartyMode()
    {
        _lightSystem.SetBrightness(30);
        _lightSystem.SetColor("White");
    }
    
    public void StartSleepMode()
    {
        _lightSystem.SetBrightness(10);
        _temparatureController.setTemparature(18);
    }
    
    public void StopSleepMode()
    {
        _lightSystem.SetBrightness(100);
        _temparatureController.setTemparature(25);
    }
}