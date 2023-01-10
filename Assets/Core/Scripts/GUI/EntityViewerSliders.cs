using ScriptableObjectArchitecture;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class EntityViewerSliders : MonoBehaviour
{
    [SerializeField] protected IAvatarVariable avatarVariable;

    [SerializeField] protected EntityStatusType entityStatusType;

    protected Func<IAvatarStats, float> UpdateValue;

    protected Slider _slider;


    [SerializeField] protected float fps = 0.04167f;
    [SerializeField] protected int currFps;

    int m_frameCounter = 0;
    float m_timeCounter = 0.0f;


    public void Raise()
    {
        if (UpdateValue == null || avatarVariable.Value == null || avatarVariable.Value.AvatarStats == null) return;

        _slider.value = UpdateValue.Invoke(avatarVariable.Value.AvatarStats);
    }


    protected void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    protected void OnEnable()
    {
        UpdateValue += entityStatusType.GetStatusValue;

        if (coRaise == null)
        {
            coRaise = StartCoroutine(CoRaise());
        }

    }

    protected void OnDisable()
    {
        if(coRaise != null)
        {
            StopCoroutine(coRaise);
        }

        UpdateValue -= entityStatusType.GetStatusValue;
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

    Coroutine coRaise;
    IEnumerator CoRaise()
    {
        while (true)
        {
            FrameCounter();
            Raise();
            yield return new WaitForSeconds(fps);
        }
    }
}
