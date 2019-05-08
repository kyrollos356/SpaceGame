using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBehavior : MonoBehaviour
{
    public float health;
    public float moveDownSpeed,moveLeftSpeed;
    public Vector3 rotate = new Vector3(0f, 0f, 0f);
    Vector3 moveDown;
    void Start()
    {
        moveDown = transform.position;
    }
    
    void Update()
    {
        transform.Rotate(rotate);
        moveDown.y = transform.position.y - moveDownSpeed;
        moveDown.x = transform.position.x - moveLeftSpeed;
        transform.position = moveDown;

    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
        health = health - 5;
    }
}
