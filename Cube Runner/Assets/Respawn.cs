using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Scene currentScene = SceneManager.GetActiveScene();

        if (collision.gameObject.CompareTag("Respawn"))
        {
            PlayerDeath.RespawnPos = new(3.41f, -4.5f);
        }
       else if (collision.gameObject.CompareTag("Respawn (1)"))
        {
            PlayerDeath.RespawnPos = new(70.21f, -4.5f);
        }
        else if (collision.gameObject.CompareTag("Respawn (2)"))
        {
            PlayerDeath.RespawnPos = new(71.14f, -4.5f);
        }
    }
}
