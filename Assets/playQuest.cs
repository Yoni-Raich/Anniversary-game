using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playQuest : MonoBehaviour {


    Button ButtonColor;
    public GameObject Plus;
    public Score score;
    public GameObject panle, panle2,panelButtons;
    public GameObject cube;
    public GameObject questionControl;
    public Text textCuontT, textCuontF;
    public bool IsHePlay = false;
    public float TimerDown = 30, timeToAnswer = 30;
    int ID, NumOfPlayers;
    public int counter = 1;

    private void Start()
    {
        ID =  FindObjectOfType<ID>().GetIDnum();
        NumOfPlayers = FindObjectOfType<ID>().GetNumP();
    }

    private void Update()
    {
        if(FindObjectOfType<questionsControl>().TakeNum  != FindObjectOfType<questionsControl>().listAsk.Count)
        { 

            ButtonColor = FindObjectOfType<questionsControl>().ColorButton();
           
           // if the timer of play question go to  -0-  this start runing 
            if (TimerDown <= 0)
            {
                // if the ID eqle to counter it is mean to run question
                if (IsHePlay == false && ID == counter)
                {
                    panle.SetActive(true);
                    panelButtons.SetActive(false);
                    questionControl.GetComponent<questionsControl>().Order();
                    cube.GetComponent<move>().enabled = false;
                    FindObjectOfType<leftMove>().enabled = false;
                    IsHePlay = true;
                   
                }
                
                // if it's dose not simaler 
                else if (IsHePlay == false && ID != counter)
                {
                panle2.SetActive(true);
                panelButtons.SetActive(false);
                cube.GetComponent<move>().enabled = false;
                FindObjectOfType<leftMove>().enabled = false;
                IsHePlay = true;
                
                }
            CountDown();
            }
            else
            {
                TimerDown -= Time.deltaTime;
            }
        }
    }
    public void CountDown()
    {
        timeToAnswer -= Time.deltaTime;
        textCuontT.text = timeToAnswer.ToString("0");
        textCuontF.text = timeToAnswer.ToString("0");

        if(timeToAnswer < 1 && panle == true)
        {
            //Set the color button 
            if (FindObjectOfType<questionsControl>().TrueQuest() == true)
            {
                ButtonColor.image.color = Color.green;

                
            }
           
        }

        if (timeToAnswer < 0)
        {
            
            if (ID != counter)
            {
                panle2.SetActive(false);
                panelButtons.SetActive(true);
                cube.GetComponent<move>().enabled = true;
                FindObjectOfType<leftMove>().enabled = true;
            }
            else
            {
                   //if the answer is true
                if (FindObjectOfType<questionsControl>().TrueQuest() == true)
                {
                    panle.SetActive(false);
                    panelButtons.SetActive(true);
                    FindObjectOfType<move>().enabled = true;
                    FindObjectOfType<leftMove>().enabled = true;
                    IsHePlay = false;
                    FindObjectOfType<Score>().ScorePoint(10);
                    Plus.SetActive(true);
                    


                }
                else
                {
                    //if the answer is false
                    panelButtons.SetActive(true);
                    panle.SetActive(false);
                    FindObjectOfType<move>().enabled = true;
                    FindObjectOfType<leftMove>().enabled = true;
                    IsHePlay = false;
                    
                    FindObjectOfType<move>().rb.AddForce(0, 0, -50000);
                    FindObjectOfType<Score>().ScorePoint(-10);
                }
                
            }
            FindObjectOfType<questionsControl>().TakeNum++;
            IsHePlay = false;
            timeToAnswer = 30;
            TimerDown = 30;
            counter++;
            if (counter > NumOfPlayers)
            {
                counter = 1;
            }
        }

    }
       
    
}
