using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.ARFoundation;

public class PlaceOnPlane : MonoBehaviour
{
    [SerializeField] private ARRaycastManagerVariable m_raycastManagerVariable;
    [SerializeField] private GameEvent m_placementUpdate;

    [SerializeField] private GameObject m_placePrefab;
    private Transform m_spawnedObj;

    List<ARRaycastHit> hitResults = new List<ARRaycastHit>();

    private ARRaycastManager RaycastManager
    {
        get { return m_raycastManagerVariable.Value; }
    }

    private bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if(Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(0).position;
            return true;
        }

        touchPosition = default;
        return false;
    }

    private void Update()
    {
        if (!RaycastManager) return;

        if(!TryGetTouchPosition(out Vector2 touchPosition)) return;

        if (RaycastManager.Raycast(touchPosition, hitResults, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
        {
            Pose hitPose = hitResults[0].pose;

            if(m_spawnedObj == null)
            {
                m_spawnedObj = Instantiate(m_placePrefab, hitPose.position, hitPose.rotation).transform;
            }
            else
            {
                m_spawnedObj.position = hitPose.position;
            }

            m_placementUpdate?.Raise();
        }
    }
}
