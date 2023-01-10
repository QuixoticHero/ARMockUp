using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "EntityStatusEnergy", menuName = "Database/EntityStatusType/Energy", order = 120)]
public class EntityStatusEnergy : EntityStatusType
{
    public override float GetStatusValue(IAvatarStats avatarStats)
    {
        return avatarStats.Energy;
    }
}
