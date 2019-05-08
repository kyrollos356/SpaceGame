using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionInvertet : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider ship)
    {
        
        waveOneBlackRocket wavePositionChanger;
        if (ship.gameObject.GetComponent<CubeIstantiater>())
        {
            wavePositionChanger = ship.gameObject.GetComponent<waveOneBlackRocket>();
            wavePositionChanger.movementAxis = wavePositionChanger.movementAxis * -1;
            Debug.Log(wavePositionChanger.movementAxis+ ""+""+ship.gameObject.name);
        }
    
      
    }
}
