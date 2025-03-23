using ObserverPattern.Core;
using ObserverPattern.Enum;
using ObserverPattern.Executor;
using ObserverPattern.Factory;
using ObserverPattern.Interfaces;
using ObserverPattern.Models;

namespace ObserverPattern.Components;

public class VoiceCommandManager : ISmartHomeComponent
{
    private EnvironmentState _environment;
    
    public VoiceCommandManager(EnvironmentState environment)
    {
        _environment = environment;
    }
    
    public void update(SENSOR sensor, Command command)
    {
        if (sensor == SENSOR.SOUND)
        {
            StateChangeExecutor sce = ExecutorFactory.getExecutor(command, _environment);
            sce.execute();
        }
    }
    
    public EnvironmentState getEnvironment()
    {
        return _environment;
    }
}