using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using System;



[Serializable, Inspectable]
public class ThrowUtility : Action
{
    [Inspectable]
    public string utility;
    [Inspectable]
    public Vector3 target;
}
