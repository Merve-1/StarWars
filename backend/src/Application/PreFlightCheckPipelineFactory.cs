using Application.Handler;
using Application.Interfaces;

namespace Application;

public static class PreFlightCheckPipelineFactory
{
    public static IPreFlightCheckHandler Build()
    {
        var crew = new CrewCapacityCheckHandler();
        var hyperdrive = new HyperdriveRatingCheckHandler();
        var mglt = new MgltCheckHandler();
        var cost = new CostIntegrityCheckHandler();
        var consumables = new ConsumablesCheckHandler();
        
        crew.SetNext(hyperdrive);
        hyperdrive.SetNext(mglt);
        mglt.SetNext(cost);
        cost.SetNext(consumables);
        
        return crew;
    }
}