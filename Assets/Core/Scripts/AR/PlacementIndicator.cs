using ScriptableObjectArchitecture;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlacementIndicator : MonoBehaviour
{
    [SerializeField] private ARRaycastManagerVariable m_raycastManagerVariable;
    [SerializeField] private GameObject m_visual;

    private bool m_isActive = true;

    public bool IsActive
    {
        get { return m_isActive; }
        set { m_isActive = value; }
    }

    public GameObject Visual
    {
        get 
        {
            if (m_visual == null)
            {
                m_visual = transform.GetChild(0).gameObject;
            }
            return m_visual; 
        }
    }

    public void PlacementUpdate()
    {
        IsActive = false;
        Visual.SetActive(false);
    }

    private ARRaycastManager RaycastManager
    {
        get { return m_raycastManagerVariable.Value; }
    }

    private void Start()
    {
        IsActive = true;
        Visual.SetActive(false);
    }

    private void Update()
    {
        if (!IsActive || !RaycastManager) return;

        List<ARRaycastHit> hitResults= new List<ARRaycastHit>();
        RaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hitResults, TrackableType.Planes);

        if(hitResults.Count > 0)
        {
            transform.position = hitResults[0].pose.position;
            transform.rotation = hitResults[0].pose.rotation;

            if(!Visual.activeInHierarchy)
                Visual.SetActive(true);
        }
    }
}
