using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duplicate : MonoBehaviour {

    public Vector3 newPosition = new Vector3(0,0,2);

    public int startCreate = 0;
    public float timer = 10;
    public int sumObsticles = 5,distence = 3;
    int counter = 0,errorObject;
    public GameObject getForDup;
    public GameObject getForDup2;
   
   List<GameObject> listDuplicate = new List<GameObject>();
    System.Random rand = new System.Random();
    public Material material;

   

    void Start ()
    {


        errorObject = rand.Next(5, 20);
        dup();



    }
    
    public void dup()
    {
        for (int i = startCreate; i < sumObsticles; i++)
        {
            if (counter != errorObject)
            {
                listDuplicate.Add(Instantiate(getForDup));
                newPosition.x = rand.Next(-6, 6);
                listDuplicate[i].transform.position += newPosition;
                newPosition.z += distence;
                counter++;
            }
            else if (counter == errorObject)
            {
                listDuplicate.Add(Instantiate(getForDup2));
                newPosition.x = rand.Next(-12, 2);
                listDuplicate[i].transform.position += newPosition;
                newPosition.z += distence;
                // listDuplicate[i].GetComponent<Renderer>().material = material;
                listDuplicate[i].tag = "Obsticles";
                counter = 0;
                errorObject = rand.Next(5, 20);

            }
           
        }
        
    }
    public void FixedUpdate()
    {
        timer -= Time.deltaTime;
        if(timer <= 0 )
        {
            timer = 300;
            sumObsticles += 300;
            startCreate = sumObsticles -300;
            dup();
            
            
        }
    }
}
