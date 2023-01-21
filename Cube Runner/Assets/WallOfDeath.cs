using UnityEngine;

public class WallOfDeath : MonoBehaviour
{
    private float x = -31.77f;
    private void Update()
    {
        transform.position = new Vector3(x, transform.position.y);
        x += 5.2f * Time.deltaTime;
    }
}
