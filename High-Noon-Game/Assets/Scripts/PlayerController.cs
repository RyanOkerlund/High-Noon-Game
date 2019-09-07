using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public KeyCode fireButton;

    //private GameObject aimSlider;

    //private GameObject aimSliderCrosshair;
    //private Animator crosshairAnim;

    //void Start()
    //{
    //    aimSlider = this.transform.GetChild(0).gameObject;

    //    aimSliderCrosshair = aimSlider.transform.GetChild(0).gameObject;
    //    crosshairAnim = aimSliderCrosshair.GetComponent<Animator>();
    //}

    //void Update()
    //{
    //    if (Input.GetKeyDown(fireButton))
    //    {
    //        //crosshairAnim.SetBool("isFirePressed", true);
    //        crosshairAnim.enabled = false;
    //        //aimSliderCrosshair.AddComponent<Rigidbody2D>();
    //        aimSliderCrosshair.AddComponent<BoxCollider2D>();
    //    }
    //}

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.tag == "GreenZone")
    //        Debug.Log("In the Green Zone!");
    //    else if (collision.tag == "OrangeZone")
    //        Debug.Log("In the Orange Zone!");
    //    else if (collision.tag == "RedZone")
    //        Debug.Log("In the Red Zone!");
    //}
}
