using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "EntityStatusHealth", menuName = "Database/EntityStatusType/Health", order = 120)]
public class EntityStatusHealth : EntityStatusType
{
    public override float GetStatusValue(IAvatarStats avatarStats)
    {
        return avatarStats.Health;
    }
}
