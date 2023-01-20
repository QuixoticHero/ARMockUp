using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AvatarActionTriggers : MonoBehaviour, IDisableLocomotion
{
    private Animator m_anim;
    private AvatarAnimationController m_animCtrl;
    private IEnergySource m_energySource;

    private int m_stateHash;
    private int m_stateId;

    [SerializeField] private float actionEnergyCost = 25;
    [SerializeField] private string nameState;
    [SerializeField] private string nameId;
    [SerializeField] private AnimationCurve curve;

    public event Func<bool> onDisableLocomotion;

    public void CharacterAction()
    {
        if (!CanUseAction() || DisableLocomotion()) return;

        m_energySource.ModifyEnergy(actionEnergyCost);

        m_animCtrl.AnimationStateHash = m_stateHash;
        m_animCtrl.AnimationCurve = curve;

        m_anim.SetTrigger(m_stateId);
    }

    private void Awake()
    {
        Transform parent = transform.GetHighParentWithComponentType<IAvatar>();

        m_anim = parent.GetComponent<Animator>();
        m_animCtrl = parent.GetComponent<AvatarAnimationController>();
        m_energySource = parent.GetComponent<IEnergySource>();

        m_stateHash = Animator.StringToHash(nameState);
        m_stateId = Animator.StringToHash(nameId);
    }

    private void OnEnable()
    {
        IDisableLocomotion[] scripts = transform.GetComponentsInHierarchy<IDisableLocomotion>();
        foreach (IDisableLocomotion script in scripts)
        {
            script.onDisableLocomotion += IsActionActive;
        }
    }

    private void OnDisable()
    {
        IDisableLocomotion[] scripts = transform.GetComponentsInHierarchy<IDisableLocomotion>();
        foreach (IDisableLocomotion script in scripts)
        {
            script.onDisableLocomotion -= IsActionActive;
        }
    }

    private bool CanUseAction()
    {
        return m_energySource.Energy >= actionEnergyCost;
    }

    private bool IsActionActive()
    {
        return m_anim.GetCurrentAnimatorStateInfo(0).fullPathHash == m_stateHash
            || m_anim.GetNextAnimatorStateInfo(0).fullPathHash == m_stateHash;
    }
    
    private bool DisableLocomotion()
    {
        if (onDisableLocomotion == null) return false;

        Delegate[] methods = onDisableLocomotion.GetInvocationList();
        foreach (Delegate method in methods)
        {
            if (method == null) continue;

            bool result = method.DynamicInvoke().ConvertTo<bool>();
            if (result) return true;
        }

        return false;
    }
}
