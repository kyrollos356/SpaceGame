using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public AudioSource fireSound;
    
    Color fireColor;
    public RawImage fire;
    Vector3 mousePos;
    private void Start()
    {
        fireSound = GetComponent<AudioSource>();
        
    }
    void Update()
    {
        fire.color = fireColor;
        mousePos = Input.mousePosition;
        transform.position = mousePos;
        if (Input.GetMouseButton(0))
        {
            fireSound.Play();
            fireColor.a = 1f ;
            fireColor.r = 255;
            fireColor.g = 255;
            fireColor.b = 255;
            Invoke("returntoTransparent",0.3f);
        }
    }
    public void returntoTransparent()
    {
        fireColor.a = 0;
    }
}
