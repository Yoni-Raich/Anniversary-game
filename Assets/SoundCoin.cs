using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCoin : MonoBehaviour {

    public AudioSource sound;

    public void CoinHeat()
    {
        sound.Play();
    }
}
