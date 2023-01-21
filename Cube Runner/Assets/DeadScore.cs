using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeadScore : MonoBehaviour
{
    public TMP_Text ScoreText;

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Score.ScoreString;
    }
}
