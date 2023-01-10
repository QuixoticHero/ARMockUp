using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TransformExtention
{
    public static Vector3 GetVectorDisplace(this Transform transform, Vector3 pos)
    {
        return (pos.x * transform.right) + (pos.y * transform.up) + (pos.z * transform.forward);
    }
}
