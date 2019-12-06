﻿using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 2f;

//    public GameObject completeGameUI;

  //  public void CompleteGame() {

  //      completeGameUI.SetActive(true);

  //  }

    public void EndGame() {

        if (gameHasEnded == false) {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }

    }

    void Restart() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}