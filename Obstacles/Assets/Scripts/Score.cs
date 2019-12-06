using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public int scoreText = 0;

	// Update is called once per frame
	void Update () {

        scoreText = scoreText + 1;

	}
}
