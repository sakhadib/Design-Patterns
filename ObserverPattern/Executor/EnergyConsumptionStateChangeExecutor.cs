using ObserverPattern.Core;
using ObserverPattern.Models;

namespace ObserverPattern.Executor;

public class EnergyConsumptionStateChangeExecutor : StateChangeExecutor
{
    public EnergyConsumptionStateChangeExecutor(EnvironmentState environmentState, Command command)
    {
        _environment = environmentState;
        _command = command;
    }
    
    public override void execute()
    {
        _environment.SetEnergyConsumption(_command);
    }
}