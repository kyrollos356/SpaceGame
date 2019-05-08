using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavesBehave : MonoBehaviour
{
    public GameObject[] Instantiaters;

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject Instantiater in Instantiaters)
        {
            if (!Instantiater) Debug.Log("No GOBJ"); 
        }
    }
}
