using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "EntityStatusHealthMax", menuName = "Database/EntityStatusType/HealthMax", order = 120)]
public class EntityStatusHealthMax : EntityStatusType
{
    public override float GetStatusValue(IAvatarStats avatarStats)
    {
        return avatarStats.HealthMax;
    }
}
