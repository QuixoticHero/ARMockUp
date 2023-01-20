using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarUIToggle : MonoBehaviour
{
    private IAvatar avatar;

    private GameObject target;

    private void Awake()
    {
        avatar = transform.GetFirstComponentFromParent<IAvatar>();

        if (avatar == null)
        {
            Debug.Log("No Avatar Type Found");
            Destroy(gameObject);
        }

        if(target == null)
        {
            target = gameObject;
        }

        target.SetActive(false);
    }

    public void CharacterAvatar(IAvatar entity)
    {
        target.SetActive((avatar != null) ? avatar.Equals(entity) : false);
    }

}
