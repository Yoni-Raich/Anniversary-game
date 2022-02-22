using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OKscript : MonoBehaviour {

    public GameObject panelSetTime;

    public void ActivF()
    {
        panelSetTime.SetActive(false);
    }
    public void ActivT()
    {
        panelSetTime.SetActive(true);
    }
}
