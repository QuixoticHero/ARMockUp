using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDestructibleTarget : ITarget
{
    public float Health { get; }
    public float HealthMax { get; }
    public float HealthRatio { get; }
}
