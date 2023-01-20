using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TransformExtention
{
    public static Vector3 GetVectorDisplace(this Transform transform, Vector3 pos)
    {
        return (pos.x * transform.right) + (pos.y * transform.up) + (pos.z * transform.forward);
    }

    public static T[] GetComponentsInHierarchy<T>(this Transform transform)
    {
        Transform parent = transform;
        while (parent.parent != null)
        {
            parent = parent.parent;
        }

        T[] values = parent.GetComponentsInChildren<T>();

        return values;
    }

    public static Transform GetHighParent(this Transform transform)
    {
        Transform parent = transform;
        while (parent.parent != null)
        {
            parent = parent.parent;
        }

        return parent;
    }

    public static Transform GetHighParentWithComponentType<T>(this Transform transform)
    {
        Transform parent = transform;
        T anchor = parent.GetComponent<T>();

        while (parent.parent != null && anchor == null)
        {
            anchor = parent.GetComponent<T>();
            if (anchor != null) return parent;

            parent = parent.parent;
        }

        return parent;
    }

    public static T GetFirstComponentFromParent<T>(this Transform transform)
    {
        Transform parent = transform;
        T value = parent.GetComponent<T>();

        while (parent.parent != null && value == null)
        {
            value = parent.GetComponent<T>();
            parent = parent.parent;
        }

        if(value == null)
        {
            value = parent.GetComponent<T>();
        }

        return value;
    }
}
