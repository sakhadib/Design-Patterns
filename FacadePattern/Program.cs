using FacadePattern;
using FacadePattern.ConcreteSystems;
using FacadePattern.Facade;

class main
{
    public static void Main(string[] args)
    {
        HomeSystemFacade homeSystemFacade = FacadeBuilder.buildFacade();
        homeSystemFacade.StartMovieMode();
    }
    
}