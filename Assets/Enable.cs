using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enable : MonoBehaviour {

    public GameObject plus;
    public void DisablePlus()
    {
        plus.SetActive(false);
    }
}
