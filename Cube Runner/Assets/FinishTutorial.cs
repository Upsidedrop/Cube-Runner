using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTutorial : MonoBehaviour
{
    public Transform cam;
    void Update()
    {
        if (cam.position.x > 132)
        {
            SceneManager.LoadScene(0);
        }
    }
}
