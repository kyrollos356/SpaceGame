﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthBehave : MonoBehaviour
{
    Vector3 rotate = new Vector3(0,0.01f,-0.01f);
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotate);
    }
}
