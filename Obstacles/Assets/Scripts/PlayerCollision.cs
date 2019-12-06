using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            //SceneManager.LoadScene("GameOver");

            FindObjectOfType<GameManager>().EndGame();
        }

        if(collisionInfo.collider.tag == "Finish")
        {
          Application.Quit();
        }

    }

}
