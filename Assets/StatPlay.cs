using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;


public class StatPlay : MonoBehaviour {

    public Text setClock;
    public Text countText;
    bool timerOn = false;
    public int minuts;
    int hours;

    public void Start()
    {
        
        minuts = DateTime.Now.Minute;
        hours = DateTime.Now.Hour;
        setClock.text = hours.ToString() + ":" + minuts.ToString();
    }

    public void Starting()
    {
        if (DateTime.Now.Minute == minuts)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            timerOn = true;
        }
    }      
	
    public void UpClick()
    {
        minuts += 1;
        setClock.text = hours.ToString() + ":" + minuts.ToString();

    }
    public void DownCklic()
    {
        minuts -= 1;
        setClock.text = hours.ToString() + ":" + minuts.ToString();
    }
    void Update ()
    {
		if(timerOn == true)
        {
            countText.text = DateTime.Now.ToString("hh:mm:ss");
            if (minuts == DateTime.Now.Minute)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        
    }
}
