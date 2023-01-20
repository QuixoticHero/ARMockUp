using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "AvatarDatabase", menuName = "Database/AvatarDatabase", order = 120)]
public class AvatarDatabase : TargetDatabase
{
    private Dictionary<ITarget, IAvatar> avatars = new Dictionary<ITarget, IAvatar>();

    public IAvatar GetAvatarWithinRange(Vector3 origin, Vector3 forward, ITarget ignoreTarget = null)
    {
        ITarget target = GetTargetWithinRange(origin, forward, ignoreTarget);

        Debug.Log(target);
        if (target == null || !avatars.ContainsKey(target)) return null;

        return avatars[target];
    }

    public IAvatar GetAvatar(ITarget target)
    {
        if (!avatars.ContainsKey(target)) return null;

        return avatars[target];
    }

    public void Add(ITarget target, IAvatar avatar)
    {
        if(!avatars.ContainsKey(target))
        {
            avatars.Add(target, avatar);
            targets.Add(target);
        }
    }

    public override void Remove(ITarget target)
    {
        if (avatars.ContainsKey(target))
        {
            avatars.Remove(target);
            targets.Remove(target);
        }
    }
}
