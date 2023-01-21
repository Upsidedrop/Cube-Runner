using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public static Vector2 RespawnPos = new(3.41f, -4.5f);
    public TrailRenderer trail;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (collision.gameObject.CompareTag("Deadly"))
        {
            if (currentScene.buildIndex == 2)
            {
                SceneManager.LoadScene(3);
            }
            else
            {
                transform.position = RespawnPos;
                trail.Clear();
            }
        }
    }

}
