using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAvatarStatsFollow : MonoBehaviour
{
    [SerializeField] private TransformVariable cameraVariable;
    [SerializeField] private Vector3 offset;
    private IAvatar avatar;

    public void CharacterAvatar(IAvatar newAvatar)
    {
        avatar = newAvatar;

        if (avatar == null) return;

        transform.position = avatar.Position;
    }

    private void Update()
    {
        if(avatar == null || cameraVariable.Value == null) return;

        transform.position = avatar.Position + avatar.GetVectorDisplace(offset);
        transform.LookAt(cameraVariable.Value);
    }

}
