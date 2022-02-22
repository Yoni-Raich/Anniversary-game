using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFwollo : MonoBehaviour {

    public Transform player;
    public Vector3 destens;
    
	// Update is called once per frame
	void Update ()
    {
        transform.position = player.position + destens;
	}
}
