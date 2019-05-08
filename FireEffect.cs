using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEffect : MonoBehaviour
{
    GameObject currentFire;
    public GameObject fire;
    int fireIndex = 0;
    GameObject[] Destroyer;
    void Update()
    {
        if (fireIndex >= 2)
        {
            fireIndex = 0;

        }
        if (Input.GetMouseButtonDown(0))
        {
            Destroyer = GameObject.FindGameObjectsWithTag ("Fire");
            foreach (GameObject enemy in Destroyer)
            {
                Destroy(enemy);
            }
            InstantiateFire();
            }
    }
    private void InstantiateFire()
    {
        currentFire = fire;
        Instantiate(currentFire, transform.position, Quaternion.identity);
        fireIndex = fireIndex + 1;
    }
 
}
