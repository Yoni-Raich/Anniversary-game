using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ID : MonoBehaviour
{


    public InputField InputYourNum;
    public InputField InputPlayers;
    public static int IDnum,NumP,minots;

   public void SetID()
    {
        IDnum = int.Parse(InputYourNum.text);
        NumP = int.Parse(InputPlayers.text);
        minots = FindObjectOfType<StatPlay>().minuts;
        Debug.Log(IDnum + "_" + NumP);
    }
   public int GetIDnum()
    {
        return IDnum;
    }
    public int GetNumP()
    {
        return NumP;
    }
    public int GetMinots()
    {
        return minots;
    }
}