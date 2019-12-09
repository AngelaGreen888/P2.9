using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Menu : MonoBehaviour {
    public GameObject mainMenu;
    public GameObject instructionMenu;

    public void StartGame() {
        mainMenu.SetActive(false);
        instructionMenu.SetActive(true);
    }


    public void Quit()
    {
        Application.Quit();
    }
}
