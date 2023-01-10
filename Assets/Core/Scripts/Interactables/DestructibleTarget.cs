using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleTarget : SimpleTarget, IDestructibleTarget
{
    protected float health = 100;
    [SerializeField] protected float maxHealth = 100;
    
    public float Health => health;
    public float HealthMax => maxHealth;
    public float HealthRatio => health / maxHealth;

}
