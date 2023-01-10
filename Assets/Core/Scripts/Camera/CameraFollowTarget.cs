using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowTarget : MonoBehaviour
{
    [SerializeField] private IAvatar avatar;

    [SerializeField] private float distance = 2f;
    [SerializeField] private Vector3 offset = new Vector3(0, 1.5f);

    [SerializeField] private Vector3 lookatOffset = new Vector3(0, 0.5f);

    public void CharacterAvatar(IAvatar target)
    {
        avatar = target;
    }

    private void Update()
    {
        if(avatar == null) return;

        transform.position = avatar.Position + (-avatar.Forward * distance) 
            + avatar.GetVectorDisplace(offset);

        transform.LookAt(avatar.Position + lookatOffset);
    }
}
