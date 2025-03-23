using ObserverPattern.Enum;
using ObserverPattern.Models;

namespace ObserverPattern.Interfaces;

public interface ISmartHomeComponent
{
    void update(SENSOR sensor, Command command);
}