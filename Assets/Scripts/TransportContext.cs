using UnityEngine;
public class TransportContext
{
    private ITransportStrategy _strategy;

    public void SetStrategy(ITransportStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ExecuteTransport()
    {
        if (_strategy == null)
        {
            Debug.LogError("Estrategia no esta definido.");
            return;
        }

        _strategy.Travel();
    }
}
