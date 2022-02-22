using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimatedGif : MonoBehaviour {

    public Sprite[] animatedGif;
    public Image imageObj;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        imageObj.sprite = animatedGif[(int)(Time.time * 25) % animatedGif.Length];	
	}
}
