using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    public float Health { get; }
    public float HealthMax { get; }
    public float HealthRatio { get; }
    public void ModifyHealth(float value);
}
