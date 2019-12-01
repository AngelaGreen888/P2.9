using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadComplete : MonoBehaviour {

    public void LoadNextLevel() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
