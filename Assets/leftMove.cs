using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftMove : MonoBehaviour {

    float screen;
    void Start()
    {
       screen = Screen.width;
        
        
    }
    public void movingLeft()
    {
        FindObjectOfType<move>().TaskOnClickLeft();
    }
	// Update is called once per frame
	void Update ()
    {
        
       if(Input.touchCount > 0)
        {
           if(Input.GetTouch(0).position.x > screen/2)
            {
                FindObjectOfType<move>().TaskOnClickRight();
            }
           else
            {
                FindObjectOfType<move>().TaskOnClickLeft();
            }
        }
        
	}
}
