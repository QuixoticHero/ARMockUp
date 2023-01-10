using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using System.Linq;

public class DemoSetSelectedAvatar : MonoBehaviour
{
    [SerializeField] private IAvatarVariable characterAvatarVariable;
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

        characterAvatarVariable.Value = avatars[0];
    }
}
