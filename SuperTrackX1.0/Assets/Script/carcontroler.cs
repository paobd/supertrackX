using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carcontroler : MonoBehaviour
{
    public WheelCollider llantadelanteraIZQWC;
    public WheelCollider llantadelanteraDERWC;

    public float torque = 200;
    public float acelerracion;
    public float fuerzatorque;

    public float pedal;

    public void ControlPedal()
    {
        pedal = acelerracion;
        pedal += 0.1f; 
    }
    public void Arranque()
    {

    }



    private void Update()
    {
        llantadelanteraDERWC.motorTorque = torque * Input.GetAxis("Vertical");
        llantadelanteraIZQWC.motorTorque = torque * Input.GetAxis("Vertical");

    }



}
