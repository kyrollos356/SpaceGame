using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlMngr : MonoBehaviour
{
    
    public void LoadHighScoreLevel(string lvlName)
    {
       
        Application.LoadLevel(lvlName);
    }
}
