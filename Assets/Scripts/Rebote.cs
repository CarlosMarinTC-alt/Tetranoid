using UnityEngine;
using UnityEngine.SceneManagement;

public class Rebote : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Dirección inicial aleatoria
        Vector2 dir = new Vector2(Random.Range(-0.5f,0.5f), Random.Range(-0.5f,0.5f)).normalized;
        rb.linearVelocity = dir * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            Destroy(collision.gameObject); // desaparece el cuadro
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.CompareTag("Floor"))
    {
        SceneManager.LoadScene("Game_Over");
    }
}


    void Update()
    {
        rb.linearVelocity = rb.linearVelocity.normalized * speed;
    }
}