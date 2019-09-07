using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    private bool isFirePressed;

    private void Start()
    {
        this.GetComponent<BoxCollider2D>().enabled = false;
        isFirePressed = false;
    }

    private void OnValidate()
    {
        this.GetComponent<BoxCollider2D>().enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(this.transform.parent.parent.GetComponent<PlayerController>().fireButton))
        {
            //crosshairAnim.SetBool("isFirePressed", true);
            this.GetComponent<Animator>().enabled = false;
            isFirePressed = true;
            //aimSliderCrosshair.AddComponent<Rigidbody2D>();
            this.GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isFirePressed)
        {
            if (collision.tag == "GreenZone")
                Debug.Log("In the Green Zone!");
            else if (collision.tag == "OrangeZone")
                Debug.Log("In the Orange Zone!");
            else if (collision.tag == "RedZone")
                Debug.Log("In the Red Zone!"); 
        }
    }
}
