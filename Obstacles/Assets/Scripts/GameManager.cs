using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public static GameManager Instance{get{return instance;}}

    bool gameHasEnded = false;
    public float restartDelay = 2f;
    public int triesScore = 1;
    public Text finalMessage;

    public GameObject completeGameUI;
    public GameObject mainUI;
    public GameObject instructionsUI;
    public GameObject scorePanel;

    public GameObject movementScript;

    private void Start(){
      if(PlayerPrefs.GetInt("triesScore") <= 1){
            triesScore = 1;
        mainUI.SetActive(true);
        instructionsUI.SetActive(false);
        completeGameUI.SetActive(false);
        scorePanel.SetActive(false);
      }else{
        mainUI.SetActive(false);
        instructionsUI.SetActive(false);
        completeGameUI.SetActive(false);
        scorePanel.SetActive(true);
      }
    }

  private void Awake(){
      instance = this;
      if (PlayerPrefs.HasKey ("triesScore")){
        if(PlayerPrefs.GetInt("triesScore") <= 1){
        triesScore =  PlayerPrefs.GetInt("triesScore");
        }
        else{
        movementScript.GetComponent<PlayerMovement>().enabled = true;
        triesScore =  PlayerPrefs.GetInt("triesScore");
        }
      }
      else{
        Save();
      }
  }

  public void Save(){
        PlayerPrefs.SetInt("triesScore", triesScore+1);
     }
  public void reSetSave(){
        PlayerPrefs.SetInt("triesScore", 1);
        triesScore = 0;
  }

  public void CompleteGame() {
    scorePanel.SetActive(false);
    finalMessage.text = "It took " + PlayerPrefs.GetInt("triesScore").ToString() + " tries";
    GameManager.instance.reSetSave();
    movementScript.GetComponent<PlayerMovement>().enabled = false;
    completeGameUI.SetActive(true);

   }

    public void EndGame() {

        if (gameHasEnded == false) {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }

    }

    void Restart() {
        GameManager.instance.Save();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void Quit(){
      Application.Quit();
    }
}
