using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarStrategy : ITransportStrategy
{
    public void Travel()
    {
        Debug.Log("Carro: Con costo alto, pero el mas rapido.");
    }
}
