using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed = 5f; // Speed of movement
    public Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hola mundo!" + speed);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Flecha derecha --> 1
        //Flecha Izquierda --> -1
        // no se preciona nada --> 0

        float input = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(input * speed, 0);
    }
}
