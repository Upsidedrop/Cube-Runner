using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialLoader : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene(1);
    }
}
