using FacadePattern.ConcreteSystems;
using FacadePattern.Facade;

namespace FacadePattern;

public class FacadeBuilder
{
    public static HomeSystemFacade buildFacade()
    {
        EnvironmentSystem environmentSystem = new EnvironmentSystem();
        LightController lightController = new LightController();
        SecurityCamera securityCamera = new SecurityCamera();
        SmartLock smartLock = new SmartLock();
        TemparatureController temparatureController = new TemparatureController();
        

        return new HomeSystemFacade(environmentSystem, securityCamera, smartLock, temparatureController, lightController);
    }
}