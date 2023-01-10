using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnergySource
{
    public float Energy { get; }
    public float EnergyRatio { get; }
    public void UseEnergy(float value);
}
