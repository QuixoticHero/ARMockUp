using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class TransformSetter : MonoBehaviour
{
    [SerializeField] protected TransformVariable transformVariable;

    [SerializeField] protected Transform presetTransform;

    private Transform GetTransform
    {
        get
        {
            if (presetTransform == null)
            {
                presetTransform = transform;
            }

            return presetTransform;
        }
    }

    // Start is called before the first frame update
    void OnEnable()
    {
        transformVariable.Value = GetTransform;
    }

    // Update is called once per frame
    void OnDisable()
    {
        if (transformVariable.Value == GetTransform)
        {
            transformVariable.Value = null;
        }
    }
}
