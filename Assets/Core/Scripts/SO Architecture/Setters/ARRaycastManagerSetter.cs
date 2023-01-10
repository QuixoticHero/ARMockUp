using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARRaycastManagerSetter : MonoBehaviour
{
    [SerializeField] protected ARRaycastManagerVariable m_arMaycatManagerVariable;

    [SerializeField] protected ARRaycastManager m_arRaycastManager;

    private ARRaycastManager RaycatManager
    {
        get 
        { 
            if(m_arRaycastManager == null)
            {
                m_arRaycastManager = GetComponent<ARRaycastManager>();
            }

            return m_arRaycastManager;
        }
    }

    void OnEnable()
    {
        if (RaycatManager)
        {
            m_arMaycatManagerVariable.Value = RaycatManager;
        }
    }

    void OnDestroy()
    {
        if (RaycatManager != null && m_arMaycatManagerVariable.Value == RaycatManager)
        {
            m_arMaycatManagerVariable.Value = null;
        }
    }
}
