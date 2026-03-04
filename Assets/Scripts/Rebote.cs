using UnityEngine;
using UnityEngine.SceneManagement;

public class Rebote : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;
    
    public bool Disapear = false;
    public Color baseColor = Color.white;
    public Color oneColor = Color.red;

    private Vector2 direccionAntesDeChoque; // Aquí guardamos el rumbo

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        // Dirección inicial
        Vector2 dir = new Vector2(Random.Range(-0.5f, 0.5f), 0.5f).normalized;
        rb.linearVelocity = dir * speed;
    }

    void Update()
    {
        // IMPORTANTE: Guardamos la dirección en cada frame MIENTRAS no esté chocando
        // Esto nos permite saber hacia dónde iba la bola antes de que Unity la haga rebotar
        if (rb.linearVelocity != Vector2.zero)
        {
            direccionAntesDeChoque = rb.linearVelocity.normalized;
        }

        // Mantener velocidad constante
        rb.linearVelocity = rb.linearVelocity.normalized * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            if (Disapear)
            {
                // Si tenemos el poder, ignoramos el rebote de Unity
                // y le devolvemos su rumbo original inmediatamente
                rb.linearVelocity = direccionAntesDeChoque * speed;
                
                // Quitamos el collider un momento para que pase a través sin trabarse
                collision.collider.isTrigger = true;
            }

            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Floor"))
        {
            SceneManager.LoadScene("Game_Over");
        }

        if (collision.CompareTag("PowerUp"))
        {
            ActivarPowerUp();
            Destroy(collision.gameObject);
        }
        
        // Si el bloque se volvió trigger por el poder, también lo destruimos aquí
        if (collision.CompareTag("Block") && Disapear)
        {
            Destroy(collision.gameObject);
        }
    }

    void ActivarPowerUp()
    {
        Disapear = true;
        GetComponent<SpriteRenderer>().color = oneColor;
        CancelInvoke("DesactivarPowerUp");
        Invoke("DesactivarPowerUp", 7f);
    }

    void DesactivarPowerUp()
    {
        Disapear = false;
        GetComponent<SpriteRenderer>().color = baseColor;
    }
}