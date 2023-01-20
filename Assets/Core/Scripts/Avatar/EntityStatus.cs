using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityStatus : MonoBehaviour, IAvatarStats, IEnergySource
{
    [SerializeField] protected string entityName;

    protected float health = 100;
    [SerializeField] protected float maxHealth = 100;

    [SerializeField] protected float energy = 100;
    [SerializeField] protected float maxEnergy = 100;

    [SerializeField] protected float chargeEnergy = 10;
    [SerializeField] protected float rechargeDelay = 1.15f;
    protected float rechargeTimer;

    protected Coroutine coRegenEnergy;

    public float Health => health;
    public float HealthMax => maxHealth;
    public float HealthRatio => health / maxHealth;
    public float Energy => energy;
    public float EnergyMax => maxEnergy;
    public float EnergyRatio => energy / maxEnergy;

    public Vector3 Position => transform.position;

    public void ModifyHealth(float value)
    {
        health += value;
    }

    public void ModifyEnergy(float value)
    {
        energy = Mathf.Clamp(energy - value, 0, maxEnergy);

        rechargeTimer = rechargeDelay + Time.time;
        if (coRegenEnergy == null)
        {
            coRegenEnergy = StartCoroutine(CoRegenEnergy());
        }
    }

    protected void Start()
    {
        health = maxHealth;
        energy = maxEnergy;
    }

    protected IEnumerator CoRegenEnergy()
    {
        yield return new WaitUntil(
            () =>
            {
                if (rechargeTimer < Time.time)
                {
                    energy = Mathf.Clamp(energy + (chargeEnergy * Time.deltaTime), 0, maxEnergy);
                }

                return energy >= maxEnergy;
            });

        coRegenEnergy = null;
    }


}
