using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAnimationTime
{
    public float CurrentAnimationTime();
    public AnimationCurve AnimationCurve { get; set; }
    public int AnimationStateHash { set; }
}
