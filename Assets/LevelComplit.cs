using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplit : MonoBehaviour {

	public void loadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
	
}
