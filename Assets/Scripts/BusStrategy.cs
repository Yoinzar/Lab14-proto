using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BusStrategy : ITransportStrategy
{
    public void Travel()
    {
        Debug.Log("Bus: Costo moderado, con tiempo moderado.");
    }
}
