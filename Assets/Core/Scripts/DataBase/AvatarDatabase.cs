using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "AvatarDatabase", menuName = "Database/AvatarDatabase", order = 120)]
public class AvatarDatabase : ScriptableObject
{
    private List<IAvatar> targets = new List<IAvatar>();

    [Range(0, 2)]
    [SerializeField] private float distanceImportanceMod = 1.2f;

    [Range(0.707f, 1)]
    [SerializeField] private float povAngle = 1.2f;

    [Range(5, 15)]
    [SerializeField] private float maxDistance = 15;

    [Serializable]
    private struct AvatarData
    {
        public IAvatar target;
        public float angle;
        public float dist;

        public AvatarData(IAvatar t, float a, float d)
        {
            target = t;
            angle = a;
            dist = d;
        }

        public float GetClosest()
        {
            return angle - dist;
        }
    }

    public IAvatar[] GetValuessWithinRange(Vector3 origin, Vector3 forward)
    {
        List<IAvatar> inRange = new List<IAvatar>();

        foreach (IAvatar target in targets)
        {
            float targetDot = Vector3.Dot(forward, (target.Position - origin).normalized);
            float distance = Vector3.Distance(target.Position, origin) / maxDistance;

            if (targetDot > povAngle && distance < 1)
            {
                inRange.Add(target);
            }
        }

        return inRange.ToArray();
    }

    public IAvatar GetValueWithinRange(Vector3 origin, Vector3 forward, IAvatar ignoreAvatar = null)
    {
        AvatarData result = new AvatarData(); 

        foreach (IAvatar target in targets)
        {
            if (ignoreAvatar == target) continue;

            float targetDot = Vector3.Dot(forward, (target.Position - origin).normalized);
            float distance = Vector3.Distance(target.Position, origin) / maxDistance;

            if (targetDot < povAngle || distance > 1) continue;

            if (result.target == null || targetDot - (distance * distanceImportanceMod) > result.GetClosest())
            {
                result = new AvatarData(target, targetDot, distance * distanceImportanceMod);
            }
        }

        return result.target;
    }

    public IAvatar[] GetArray()
    {
        return targets.ToArray();
    }

    public void Add(IAvatar target)
    {
        targets.Add(target);
    }

    public void Remove(IAvatar target)
    {
        if (targets.Contains(target))
        {
            targets.Remove(target);
        }
    }
}
