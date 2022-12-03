using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothType
{
    public bool isHead;
    public bool isBody;
    public bool isLegs;
    public bool isFeet;
    public bool isNone;

    public ClothType(bool isHead=false, bool isBody=false, bool isLegs=false, bool isFeet=false)
    {
        this.isHead = isHead;
        this.isBody = isBody;
        this.isLegs = isLegs;
        this.isFeet = isFeet;
        if (!(isHead && isBody && isLegs && isFeet))
            isNone = true;
        else
            isNone = false;
    }
}