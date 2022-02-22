using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{


    public Rigidbody rb;
    bool right, left;
    public float SideWays = 500f;
    public float ForwardForce = 2000f;
    public Button buttonLeft;
    public Button buttonRight;

    

    public void TaskOnClickLeft()
    {
        rb.AddForce(-SideWays * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
    public void TaskOnClickRight()
    {
        rb.AddForce(SideWays * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }


    void Update()
    {
        //keyBord
        if (Input.GetKey("d")|| Input.GetKey("right")) right = true;
        else
        {
            right = false;
        }
        if (Input.GetKey("a")|| Input.GetKey("left")) left = true;
        else
        {
            left = false;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if (left == true)
        {
            rb.AddForce(-SideWays * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (right == true)
        {
            rb.AddForce(SideWays * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1)
        {
            FindObjectOfType<GameManeger>().EndGame();
        }
    }
}