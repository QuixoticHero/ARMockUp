using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "EntityStatusHealthRatio", menuName = "Database/EntityStatusType/HealthRatio", order = 120)]
public class EntityStatusHealthRatio : EntityStatusType
{
    public override float GetStatusValue(IAvatarStats avatarStats)
    {
        return avatarStats.HealthRatio;
    }
}
