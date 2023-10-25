using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using System;

[Serializable, Inspectable]
public class Action
{
    [Inspectable]
    public string action;
    [Inspectable]
    public Vector3 actorPosition;
}
