using UnityEngine;

public class PowerUpSuperBall : MonoBehaviour
{
    public Rebote reboteScript;
    void Start()
    {

    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            reboteScript.ActivarPowerUp();
            Destroy(gameObject);
        }
    }
}
