using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeStrategy : ITransportStrategy
{
    public void Travel()
    {
        Debug.Log("Bicicleta: Sin costo, pero mucho mas lento.");
    }
}
