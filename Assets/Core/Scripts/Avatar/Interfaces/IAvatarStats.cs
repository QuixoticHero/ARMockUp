using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAvatarStats : IDamageable
{
    public float Energy { get; }
    public float EnergyMax { get; }
    public float EnergyRatio { get; }
}
