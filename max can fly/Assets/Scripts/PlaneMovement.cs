using UnityEngine;
using System.Collections;

public class PlaneMovement : MonoBehaviour {
    public float maxrotateSpeedX;
    public float rotateSpeedX;
    public float rotateAccelerationX;

    public float maxrotateSpeedY;
    public float rotateSpeedY;
    public float rotateAccelerationY;

    public float maxrotateSpeedZ;
    public float rotateSpeedZ;
    public float rotateAccelerationZ;

    public float acceleration;
    public float speed;
    public float maxSpeed;
    public float turnSpeed;
    public float deacceleration;
    public float lowestSpeed;

    // Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //rotation for plane/bomber
        if (Input.GetKey(KeyCode.W))
        {
            rotateSpeedX = rotateSpeedX + rotateAccelerationX * Time.deltaTime;
            if (rotateSpeedX > maxrotateSpeedX)
            {
                rotateSpeedX = maxrotateSpeedX;
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rotateSpeedX = rotateSpeedX - rotateAccelerationX * Time.deltaTime;
            if (rotateSpeedX < -maxrotateSpeedX)
            {
                rotateSpeedX = maxrotateSpeedX;
            }
        }
        else
        {
            if (rotateSpeedX > 0)
            {
                rotateSpeedX -= rotateAccelerationX * Time.deltaTime;
                if (rotateSpeedX < 0)
                {
                    rotateSpeedX = 0;
                }
            }
            if (rotateSpeedX < 0)
            {
                rotateSpeedX += rotateAccelerationX * Time.deltaTime;
                if (rotateSpeedX > 0)
                {
                    rotateSpeedX = 0;
                }
            }
        }
        gameObject.transform.Rotate(rotateSpeedX * Time.deltaTime, 0f, 0f);

        if (Input.GetKey(KeyCode.D))
        {
            rotateSpeedY = rotateSpeedY + rotateAccelerationY * Time.deltaTime;
            if (rotateSpeedY > maxrotateSpeedY)
            {
                rotateSpeedY = maxrotateSpeedY;
            }
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rotateSpeedY = rotateSpeedY - rotateAccelerationY * Time.deltaTime;
            if (rotateSpeedY < -maxrotateSpeedY)
            {
                rotateSpeedY = maxrotateSpeedY;
            }
        }
        else
        {
            if (rotateSpeedY > 0)
            {
                rotateSpeedY-= rotateAccelerationY * Time.deltaTime;
                if (rotateSpeedY < 0)
                {
                    rotateSpeedY = 0;
                }
            }
            if (rotateSpeedY < 0)
            {
                rotateSpeedY += rotateAccelerationY * Time.deltaTime;
                if (rotateSpeedY > 0)
                {
                    rotateSpeedY = 0;
                }
            }
        }
        gameObject.transform.Rotate(0f, rotateSpeedY * Time.deltaTime, 0f);

        if (Input.GetKey(KeyCode.Q))
        {
            rotateSpeedZ = rotateSpeedZ + rotateAccelerationZ * Time.deltaTime;
            if (rotateSpeedZ > maxrotateSpeedZ)
            {
                rotateSpeedZ = maxrotateSpeedZ;
            }
        }
        else if (Input.GetKey(KeyCode.E))
        {
            rotateSpeedZ = rotateSpeedZ - rotateAccelerationZ * Time.deltaTime;
            if (rotateSpeedZ < -maxrotateSpeedZ)
            {
                rotateSpeedZ = maxrotateSpeedZ;
            }
        }
        else
        {
            if (rotateSpeedZ > 0)
            {
                rotateSpeedZ -= rotateAccelerationZ * Time.deltaTime;
                if (rotateSpeedZ < 0)
                {
                    rotateSpeedZ = 0;
                }
            }
            if (rotateSpeedZ < 0)
            {
                rotateSpeedZ += rotateAccelerationZ * Time.deltaTime;
                if (rotateSpeedZ > 0)
                {
                    rotateSpeedZ = 0;
                }
            }
        }
        gameObject.transform.Rotate(0f,0f, rotateSpeedZ * Time.deltaTime);


       //atempt to make move
        if (Input.GetKey(KeyCode.K))
        {
            speed = speed + acceleration * Time.deltaTime;
            if (speed > maxSpeed)
            {
                speed = maxSpeed;
            }
        }
        if (Input.GetKey(KeyCode.L))
        {
            speed = speed - acceleration * Time.deltaTime;
            if (speed < lowestSpeed)
            {
                speed = lowestSpeed;
            }
        }
        gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;
    }
}
