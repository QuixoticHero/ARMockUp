using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTarget : MonoBehaviour, ITarget
{
    [SerializeField] protected TargetDatabase targetDatabase;

    public Vector3 Position => transform.position;

    protected void OnEnable()
    {
        if (targetDatabase == null) return;

        targetDatabase.AddTarget(this);
    }

    protected void OnDisable()
    {
        if (targetDatabase == null) return;

        targetDatabase.RemoveTarget(this);
    }
}
