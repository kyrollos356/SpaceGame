using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DestroyRockets : MonoBehaviour
{
    string healthTostr;
    public Text healthValue;
    public int health=100;
    private void Start()
    {
        healthTostr = health.ToString();
        healthValue.text = healthTostr;
    }
    private void Update()
    {
        if (health == 0) { Application.LoadLevel("Loser"); }
    }
    private void OnTriggerEnter(Collider rocket)
    {

        Debug.Log(rocket.gameObject.name);
        health = health - 1;
        healthTostr = health.ToString();
        healthValue.text = healthTostr;
        Destroy(rocket.gameObject);
        if (health == 0) { Application.LoadLevel("Loser"); }
    }
}

