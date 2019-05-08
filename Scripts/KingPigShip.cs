using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingPigShip : MonoBehaviour
{
    public GameObject explosion;
    public float timeToInstantiate;
    bool invoked = false;
    public GameObject[] messile;
    int health = 300;
    public float maxleft=135, maxright=-130;
    Vector3 originalPos,shift = new Vector3(50,0,-190);
    int range = Random.Range(0, 1);
    private void Start()
    {
        originalPos = transform.TransformPoint(new Vector3(0, 0, 0))+shift;
    }
    void Update()
    {
        transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z);
        if (!invoked)
        {
            InvokeRepeating("Fire", timeToInstantiate, 2.5f);
            invoked = true;
        }
        if (health <= 0)
        {
            Destroy(gameObject);
            Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
            Invoke("DestroyExp", 0.3f);
        }
    }
    private void OnMouseDown()
    {
        health = health - 2;
    }
    void Fire()
    {
        Instantiate(messile[range], originalPos, messile[range].transform.rotation);
    }
    private void DestroyExp()
    {
        Destroy(explosion);
    }
}
