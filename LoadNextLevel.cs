using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNextLevel : MonoBehaviour
{
    void Start()
    {
        Invoke("loadLVL",6);
    }
    void loadLVL()
    {
        Application.LoadLevel("Splash");
    }
   }
