using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiClosestTarget : MonoBehaviour
{
    [SerializeField] private TransformVariable cameraTransformVariable;

    [SerializeField] private Vector2Variable uiSelectPositionVariable;
    [SerializeField] private ITargetVariable highlightedVarable;
    [SerializeField] private ITargetVariable selectedVarable;

    [SerializeField] private TargetDatabase targetDatabase;

    [SerializeField] private float CanvasHeight = 1200;
    [SerializeField] private float CanvasWidth = 1600;

    [SerializeField] protected float fps = 0.04167f;
    [SerializeField] protected int currFps;

    int m_frameCounter = 0;
    float m_timeCounter = 0.0f;

    public IEnumerator Start()
    {
        while (true)
        {
            FrameCounter();
            UpdateFrame();
            yield return new WaitForSeconds(fps);
        }
    }

    private void FrameCounter()
    {
        if (Time.time > m_timeCounter)
        {
            m_timeCounter = Time.time + 1;

            currFps = m_frameCounter;
            m_frameCounter = 0;
        }
        else
        {
            m_frameCounter++;
        }
    }

    private void UpdateFrame()
    {
        if (!cameraTransformVariable || !targetDatabase || !uiSelectPositionVariable) return;

        highlightedVarable.Value = targetDatabase
            .GetTargetWithinRange(CameraObj.position, CameraObj.forward, selectedVarable.Value);

        if (highlightedVarable.Value == null)
        {
            uiSelectPositionVariable.Value = Vector2.zero;
            return;
        }

        Vector2 viewportPosition = Camera.main.WorldToViewportPoint(highlightedVarable.Value.Position);
        uiSelectPositionVariable.Value = new Vector2(viewportPosition.x * CanvasWidth, viewportPosition.y * CanvasHeight);
    }

    private Transform CameraObj
    {
        get { return cameraTransformVariable.Value; }
    }
}
