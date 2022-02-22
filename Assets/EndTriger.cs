using UnityEngine;

public class EndTriger : MonoBehaviour {

    public GameManeger GameManeger;
    private void OnTriggerEnter()
    {
        GameManeger.complitLevel();
       
    }

}
