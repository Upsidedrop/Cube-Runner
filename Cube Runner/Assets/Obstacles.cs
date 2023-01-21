using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public GameObject Prefab1;
    int currentpos = 0;
    private int obstacle;
    public Transform cam;
    public GameObject Prefab2;
    public GameObject Prefab3;
    public GameObject Prefab4;
    public GameObject Prefab5;
    public GameObject Prefab6;
    public GameObject Prefab7;
    public GameObject Prefab8;
    public GameObject Prefab9;

    private void Start()
    {
        obstacle = (int)Mathf.Ceil(Random.value * 9);
    }
    void Update()
    {
      
        if (currentpos < cam.position.x)
        {

            switch (obstacle)
            {
                case 1:
                    Debug.Log("1");
                    Instantiate(Prefab1, new Vector2(currentpos + 35, -6), Quaternion.identity);
                    break;
                case 2:
                    Debug.Log("2");
                    Instantiate(Prefab2, new Vector2(currentpos + 35.9f, -5.88f), Quaternion.identity);
                    break;
                case 3:
                    Debug.Log("3");
                    Instantiate(Prefab3, new Vector2(currentpos + 23.76f, -6), Quaternion.identity);
                    break;
                case 4:
                    Debug.Log("4");
                    Instantiate(Prefab4, new Vector2(currentpos + 24.74f, -2.8f), Quaternion.identity);
                    break;
                case 5:
                    Debug.Log("5");
                    Instantiate(Prefab5, new Vector2(currentpos + 22, -6), Quaternion.identity);
                    break;
                case 6:
                    Debug.Log("6");
                    Instantiate(Prefab6, new Vector2(currentpos + 23.7f, -6), Quaternion.identity);
                    break;
                case 7:
                    Debug.Log("7");
                    Instantiate(Prefab7, new Vector2(currentpos + 32.6f, -6), Quaternion.identity);
                    break;
                case 8:
                    Debug.Log("8");
                    Instantiate(Prefab8, new Vector2(currentpos + 23.07f, -6.38f), Quaternion.identity);
                    break;
                case 9:
                    Debug.Log("9");
                    Instantiate(Prefab9, new Vector2(currentpos + 73.8f, -4.7f), Quaternion.identity);
                    break;
            }
            currentpos += 40;
            obstacle = (int)Mathf.Ceil(Random.value * 9);

        }
    }
}
