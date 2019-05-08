using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeIstantiater : MonoBehaviour
{
    public float health;
    public float timeToInstantiate;
    public GameObject messile ;
    public GameObject explosion; 
    bool invoked = false;
    Vector3 originalPos;

    private void Start()
    {
        originalPos = transform.TransformPoint(new Vector3(0,0,0));
    }
    void Update()
    {
        originalPos = transform.TransformPoint(new Vector3(0, 0, 0));
        if (!invoked) {
            InvokeRepeating("Fire", timeToInstantiate,2.5f);
            invoked = true;
        }
    }
    void Fire()
    {  
        Instantiate(messile,originalPos, messile.transform.rotation);
    }

    private void OnMouseDown()
    {
        health = DamageDoer(health);
        DestroyIfHealthIsZero(health);
    }
    private float  DamageDoer(float health)
    {
        health = health - 5;
        return health;
    }
    private void DestroyIfHealthIsZero(float health)
    { 
        if (health <= 0)
        {
            Destroy(gameObject);
            Instantiate(explosion,gameObject.transform.position,Quaternion.identity);
            Invoke("DestroyExp",0.3f);
        }
    }
    private void DestroyExp()
    {
        Destroy(explosion);
    }
}

