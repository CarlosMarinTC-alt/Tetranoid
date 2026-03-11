using UnityEngine;
public class PowerUpDestruction : MonoBehaviour
{
    public Rebote reboteScript;
    public Vector3 posisionPowerUp1 = new Vector3(0f, 2.27f, 0f);
    public Vector3 fueraPantalla1 = new Vector3(0f, -5f,0f);
    public Vector3 posisionPowerUp2 = new Vector3(-6.54f, 3.57f, 0f);
    public Vector3 fueraPantalla2 = new Vector3(-6.54f, -5.38f,0f);
    public float speedGravity = 2f;
    public Rigidbody2D rb_pu;

    public int whichPowerUp;

    public GameObject powerUp;
    Transform powerUpTransform;
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
            switch(whichPowerUp)
            {
                case 1:
                    reboteScript.ActivarPowerUp();
                    break;
                        
            }
            Destroy(gameObject);
        }
    }

    public void AparecerPowerUp()
    {
        switch(whichPowerUp)
        {
            case 1:
                powerUpTransform = powerUp.transform;

                rb_pu.linearVelocity = fueraPantalla1 * speedGravity;
                powerUpTransform.position = posisionPowerUp1; 

                float step = speedGravity * Time.deltaTime;   

                powerUpTransform.position = Vector2.down;
                break;
        }
    }
}
