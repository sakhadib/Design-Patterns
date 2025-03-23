using ObserverPattern.Core;
using ObserverPattern.Models;

namespace ObserverPattern.Executor;

public class MotionLevelStateChangeExecutor : StateChangeExecutor
{
    public MotionLevelStateChangeExecutor(EnvironmentState environmentState, Command command)
    {
        _environment = environmentState;
        _command = command;
    }

    public override void execute()
    {
        _environment.SetMotionLevel(_command);
    }
    
}