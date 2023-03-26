using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_View : MonoBehaviour
{
    private Tank_controller tank_controller;
    private float movement;
    private float rotation;
    public Rigidbody rb;
    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f,3f,-4f); ///the total code is basically for the camera to follow along wuth player.
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if(movement!=0)
            tank_controller.Move(movement,tank_controller.GetTankModel().movement_speed);
        if(rotation!=0)
            tank_controller.Rotate(rotation,tank_controller.GetTankModel().rotate_speed);     
    }
    private void Movement()
    {
       movement = Input.GetAxis("Vertical");
       rotation = Input.GetAxis("Horizontal");

    }
    public void SetTankController( Tank_controller _tankController)
    {
        tank_controller = _tankController;
    }
    public Rigidbody GetRigidbody()
    {
       return rb; 
    }
}
