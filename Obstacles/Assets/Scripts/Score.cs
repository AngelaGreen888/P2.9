using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public static Score instance;

    public Text triesText;

    void Start(){
      instance = this;
    }

	// Update is called once per frame
	void Update () {

        triesText.text = "Tries: " + GameManager.instance.triesScore.ToString();

	}
}
