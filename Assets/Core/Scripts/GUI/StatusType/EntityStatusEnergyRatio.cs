using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "EntityStatusEnergyRatio", menuName = "Database/EntityStatusType/EnergyRatio", order = 120)]
public class EntityStatusEnergyRatio : EntityStatusType
{
    public override float GetStatusValue(IAvatarStats avatarStats)
    {
        return avatarStats.EnergyRatio;
    }
}
