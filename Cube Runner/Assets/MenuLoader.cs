using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoader : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene(0);
    }
}
