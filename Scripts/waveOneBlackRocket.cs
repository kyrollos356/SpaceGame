using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveOneBlackRocket : MonoBehaviour
{
    bool moveToOtherSide=false;
    public Vector3 movementAxis;
    void Update()
    {
        if (!moveToOtherSide) {

            moveToOtherSide =moveForward(transform.position);
                
                }    
    }
    bool moveForward(Vector3 currentPos)
    {
       
        transform.position = movementAxis + transform.position;
        bool turnSide = false;

        return turnSide;
    }
}
