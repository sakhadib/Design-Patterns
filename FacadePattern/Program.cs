using FacadePattern.ConcreteSystems;
using FacadePattern.Facade;

class main
{
    public static void Main(string[] args)
    {
        EnvironmentSystem environmentSystem = new EnvironmentSystem();
        LightController lightController = new LightController();
        SecurityCamera securityCamera = new SecurityCamera();
        SmartLock smartLock = new SmartLock();
        TemparatureController temparatureController = new TemparatureController();
        
        HomeSystemFacade homeSystemFacade = new HomeSystemFacade(environmentSystem, securityCamera, smartLock, temparatureController, lightController);
        
        homeSystemFacade.StartMovieMode();
    }
    
}