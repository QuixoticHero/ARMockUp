using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class EntityStatusType : ScriptableObject
{
    public delegate float GetStatus();
    public virtual float GetStatusValue(IAvatarStats avatarStats)
    {
        return 0;
    }
}
