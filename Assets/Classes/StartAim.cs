using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using System;


[Serializable, Inspectable]
public class StartAim : Action
{
    [Inspectable]
    public Vector3 target;
}

