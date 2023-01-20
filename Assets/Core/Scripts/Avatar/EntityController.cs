using ScriptableObjectArchitecture;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityController : MonoBehaviour, IAvatar
{
    [SerializeField] protected IntVariable ownerVariable;
    [SerializeField] protected int _ownerId = 0;

    [SerializeField] protected TargetDatabase targetDatabase;
    [SerializeField] protected AvatarDatabase avatarDatabase;

    [SerializeField] protected ITargetVariable characterTargetVariable;
    [SerializeField] protected IAvatarVariable characterAvatarVarable;

    protected ITarget characterTarget;
    protected IAvatarStats m_avatarStats;

    public int OwnerId => _ownerId;
    public Vector3 Position => transform.position;
    public Vector3 Forward => transform.forward;
    public IAvatarStats AvatarStats => m_avatarStats;

    public Vector3 GetVectorDisplace(Vector3 value)
    {
        return transform.GetVectorDisplace(value);
    }

    public void CharacterTarget(ITarget t)
    {
        characterTarget = t;
    }

    public void CharacterAvatar(IAvatar newAvatar)
    {
        if (newAvatar != (IAvatar)this) return;

        StartCoroutine(DelayAction(
            () => { characterTargetVariable.Value = characterTarget; }));
    }

    protected void Awake()
    {
        m_avatarStats = GetComponent<IAvatarStats>();
    }

    protected void OnEnable()
    {
        if (targetDatabase == null || avatarDatabase == null) return;
        
        ITarget target = GetComponent<ITarget>();

        if (ownerVariable.Value == OwnerId)
        {
            avatarDatabase.Add(target, this);
        }
        else
        {
            targetDatabase.Add(target);
        }
    }

    protected void OnDisable()
    {
        if (targetDatabase == null || avatarDatabase == null) return;

        ITarget target = GetComponent<ITarget>();

        if (ownerVariable.Value == OwnerId)
        {
            avatarDatabase.Remove(target);
        }
        else
        {
            targetDatabase.Remove(target);
        }
    }

    protected IEnumerator DelayAction(Action action, float second = 0.02f)
    {
        yield return second <= 0 ? null : new WaitForSeconds(second);
        action.Invoke();
    }
}
