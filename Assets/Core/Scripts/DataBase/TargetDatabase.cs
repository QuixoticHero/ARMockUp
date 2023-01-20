using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "TargetDatabase", menuName = "Database/TargetDatabase", order = 120)]
public class TargetDatabase : ScriptableObject
{
    protected List<ITarget> targets = new List<ITarget>();

    [Range(0,2)]
    [SerializeField] protected float distanceImportanceMod = 1.2f;

    [Range(0.707f, 1)]
    [SerializeField] protected float povAngle = 1.2f;

    [Range(5, 15)]
    [SerializeField] protected float maxDistance = 15;

    [Serializable]
    protected struct TargetData
    {
        public ITarget target;
        public float angle;
        public float dist;

        public TargetData(ITarget t, float a, float d)
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

    public ITarget GetTargetWithinRange(Vector3 origin, Vector3 forward, ITarget ignoreTarget = null)
    {
        TargetData result = new TargetData();

        foreach (ITarget target in targets)
        {
            if (ignoreTarget == target) continue;

            float targetDot = Vector3.Dot(forward, (target.Position - origin).normalized);
            float distance = Vector3.Distance(target.Position, origin) / maxDistance;

            if (targetDot < povAngle || distance > 1) continue;

            if(result.target == null || targetDot - (distance * distanceImportanceMod) > result.GetClosest())
            {
                result = new TargetData(target, targetDot, distance * distanceImportanceMod);
            }
        }

        return result.target;
    }

    public void Add(ITarget target)
    {
        targets.Add(target);
    }

    public virtual void Remove(ITarget target)
    {
        if(targets.Contains(target))
        {
            targets.Remove(target);
        }
    }
}
