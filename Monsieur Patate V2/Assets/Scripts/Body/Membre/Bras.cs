﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bras : Membre
{
    public float puissanceBras = 5;
    

    public override void Action(float analogiqueReturn = 1)
    {
        
        directionForce = transform.up;
        rb.AddForce(directionForce * puissanceBras * analogiqueReturn);
    }
}