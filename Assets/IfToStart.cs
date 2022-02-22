using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfToStart : MonoBehaviour {

    bool first = false;
    float minotCount;
    float min;
    public Text TextForMin;
    public Text TextForMinCount;
    void Start ()
    {
        FindObjectOfType<move>().enabled = false;
        FindObjectOfType<leftMove>().enabled = false;
        min = DateTime.Now.Minute + 1;
        TextForMin.text = min.ToString();

    }
		
	void Update ()
    {       
        TextForMinCount.text = DateTime.Now.ToString("mm:ss"); ;
        if(min == DateTime.Now.Minute && first == false)
        {
            FindObjectOfType<playQuest>().TimerDown = 30;
            FindObjectOfType<move>().enabled = true;
            FindObjectOfType<leftMove>().enabled = true;
            TextForMin.enabled = false;
            TextForMinCount.enabled = false;
            first = true;

        }
    }
}
