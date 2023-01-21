using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishChallenge1 : MonoBehaviour
{
    public Transform cam;
    void Update()
    {
        if (cam.position.x > 170)
        {
            SceneManager.LoadScene(0);
        }
    }
}
