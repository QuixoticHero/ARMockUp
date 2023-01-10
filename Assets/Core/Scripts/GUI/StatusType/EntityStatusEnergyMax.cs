using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "EntityStatusEnergyMax", menuName = "Database/EntityStatusType/EnergyMax", order = 120)]
public class EntityStatusEnergyMax : EntityStatusType
{
    public override float GetStatusValue(IAvatarStats avatarStats)
    {
        return avatarStats.EnergyMax;
    }
}
