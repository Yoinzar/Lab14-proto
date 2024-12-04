using UnityEngine;

public class TransportSelector : MonoBehaviour
{
    private TransportContext context;

    void Start()
    {
        context = new TransportContext();

        CallTransport(new BikeStrategy());
        CallTransport(new BusStrategy());
        CallTransport(new CarStrategy());
    }

    private void CallTransport(ITransportStrategy strategy)
    {
        if (context == null)
        {
            Debug.LogError("TransportContext no esta inicia.");
            return;
        }

        context.SetStrategy(strategy);
        context.ExecuteTransport();
    }
}