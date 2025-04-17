using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public List<AxleInfo> axleInfos; // List of axle information
    public float maxMotorTorque = 2000; // Maximum motor torque
    public float maxSteeringAngle = 30; // Maximum steering angle
    public float brakeTorque = 2000; // Brake torque

    public void FixedUpdate()
    {
        float motor = maxMotorTorque * Input.GetAxis("Vertical"); // Get motor input from vertical axis
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal"); // Get steering input from horizontal axis
        foreach (AxleInfo axleInfo in axleInfos)
        {
            if (axleInfo.steering)
            {
                axleInfo.leftWheel.steerAngle = steering; // Set steering angle for left wheel
                axleInfo.rightWheel.steerAngle = steering; // Set steering angle for right wheel
            }
            if (axleInfo.motor)
            {
                axleInfo.leftWheel.motorTorque = motor; // Set motor torque for left wheel
                axleInfo.rightWheel.motorTorque = motor; // Set motor torque for right wheel
            }
            if(Input.GetKey(KeyCode.Space))
            {
                axleInfo.leftWheel.brakeTorque = brakeTorque; // Apply brake torque to left wheel
                axleInfo.rightWheel.brakeTorque = brakeTorque; // Apply brake torque to right wheel
            }
            else
            {
                axleInfo.leftWheel.brakeTorque = 0; // Remove brake torque from left wheel
                axleInfo.rightWheel.brakeTorque = 0; // Remove brake torque from right wheel
            }            
        }
    }
}

[System.Serializable]
public class AxleInfo
{
    public WheelCollider leftWheel; // Left wheel collider
    public WheelCollider rightWheel; // Right wheel collider
    public bool motor; // Is this axle a motor axle?
    public bool steering; // Is this axle a steering axle?
}

