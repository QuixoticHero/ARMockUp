using ScriptableObjectArchitecture;
using System.Collections.Generic;
using UnityEngine;

public class DemoSetSelectedAvatar : MonoBehaviour
{
    [SerializeField] private IAvatarVariable selectedAvatarVariable;
    [SerializeField] private ITargetVariable selectedTargetAvatarVariable;

    [SerializeField] private int Ownerid = 0;

    void Start()
    {
        EntityController[] ctrls = FindObjectsOfType<EntityController>();
        
        List<IAvatar> avatars = new List<IAvatar>();

        foreach (EntityController avatar in ctrls)
        {
            if (avatar.OwnerId == Ownerid)
            {
                avatars.Add(avatar);
            }
        }

        if (avatars.Count <= 0) return;

        selectedAvatarVariable.Value = avatars[0];
        selectedTargetAvatarVariable.Value = avatars[0];
    }
}
