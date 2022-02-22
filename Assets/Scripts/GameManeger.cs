using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManeger : MonoBehaviour
{
    public Text AllScore;
    public float restartDelay = 0f;
    bool gameHasEnded = false;

    Vector3 pos = new Vector3(0, 1, 0);
    public float speedUP = 100;
    public GameObject complitLevelUI;
    public GameObject Cube;

    public void EndGame()
    {
       // if(gameHasEnded == false)
       // {
       //     gameHasEnded = true;
         
            Invoke("Restart", restartDelay);
       // }
    }
	void Restart()
    {
        Cube.transform.position = pos;
    }
    public void complitLevel()
    {
        complitLevelUI.SetActive(true);
        AllScore.text = FindObjectOfType<Score>().points.ToString();

    }

    void Update()
    {
        
        if (Cube.transform.position.z > speedUP)
            {
            FindObjectOfType<move>().ForwardForce +=500;
            speedUP += 100;


            }
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
