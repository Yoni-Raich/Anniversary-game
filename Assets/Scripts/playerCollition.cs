using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollition : MonoBehaviour
{
    public GameObject FX;
    public Score Score;
    public GameObject coin;
    public move move;
    public Vector3 backing;
    public float JumpBack = 500f;
    void OnCollisionEnter(Collision cInfo)
    {
        if(cInfo.collider.tag == "Obsticles")
        {
            // move.enabled = false;
            // FindObjectOfType<GameManeger>().EndGame();
            move.rb.AddForce(0, 0, -JumpBack);
        }
        else if(cInfo.collider.tag == "speed")
        {
            move.rb.AddForce(0, 0, 9000);
        }
        else if(cInfo.collider.tag == "Coin")
        {
            Destroy(cInfo.gameObject);
            Destroy(Instantiate(FX,transform.position,Quaternion.identity), 3);
            FindObjectOfType<Score>().ScorePoint(1);
            FindObjectOfType<SoundCoin>().CoinHeat();

        }
    }

}

     