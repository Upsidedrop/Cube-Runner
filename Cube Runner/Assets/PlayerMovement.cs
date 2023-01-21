using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float direction = 0;
    public Rigidbody2D rb;
    float speed = 1;

    private void Start()
    {
        transform.position = new Vector2(3.36f, -3.02f);
    }
    private void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
        rb.velocity = new Vector2(direction * 5.5f * speed, rb.velocity.y);
        direction = (Input.GetAxis("Horizontal"));

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 8 * Input.GetAxis("Jump"));
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Speed Boost"))
        {
            speed = 1.5f;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Speed Boost"))
        {
            speed = 1f;
        }
    }
}
