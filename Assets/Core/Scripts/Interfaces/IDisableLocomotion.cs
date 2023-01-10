using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDisableLocomotion
{
    public event Func<bool> onDisableLocomotion;

    private bool DisableLocomotion()
    {
        return false;
    }
}
