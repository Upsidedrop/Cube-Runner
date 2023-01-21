using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Challenge1Loader : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene(4);
    }
}
