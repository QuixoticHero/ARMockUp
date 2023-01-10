using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIApplyTarget : MonoBehaviour
{
    private Camera m_cam;

    [SerializeField] private Vector2Variable UITargetPosition;
    [SerializeField] private ITargetVariable possibleTargetVarable;
    [SerializeField] private ITargetVariable characterTargetVarable;

    [SerializeField] private TargetDatabase targetDatabase;

    [SerializeField] private float CanvasHeight = 1200;
    [SerializeField] private float CanvasWidth = 1600;

    [SerializeField] protected float fps = 0.04167f;
    [SerializeField] protected int currFps;

    int m_frameCounter = 0;
    float m_timeCounter = 0.0f;

    void Awake()
    {
        m_cam = GetComponent<Camera>();
    }


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
        if (!targetDatabase || !UITargetPosition) return;

        possibleTargetVarable.Value = targetDatabase
            .GetTargetWithinRange(transform.position, transform.forward, characterTargetVarable.Value);

        if (possibleTargetVarable.Value == null)
        {
            UITargetPosition.Value = Vector2.zero;
            return;
        }

        Vector2 viewportPosition = Camera.main.WorldToViewportPoint(possibleTargetVarable.Value.Position);
        UITargetPosition.Value = new Vector2(viewportPosition.x * CanvasWidth, viewportPosition.y * CanvasHeight);
    }
}
