using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBasedOnCameraDirection : MonoBehaviour
{
    [SerializeField] private Vector2Variable characterMovementVariable;

    public void CharacterMovementBasedCamera(Vector2 inputValue)
    {
        if (characterMovementVariable == null) return;

        Vector3 remapInput = new Vector3(inputValue.x, 0 , inputValue.y);
        Vector3 recalculateInput = transform.GetVectorDisplace(remapInput);

        characterMovementVariable.Value = new Vector2(recalculateInput.x, recalculateInput.z);
    }
}
