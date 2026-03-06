using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 5.5f;
    public float min = -6.3f;
    public float max = 6.3f;
    Rigidbody2D player_RB;
    // Start is called before the first frame update
    void Start()
    {
        player_RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float velocidadX = Input.GetAxis("Horizontal");
        player_RB.linearVelocity = new Vector2(velocidadX*velocidad,player_RB.linearVelocity.y);
        player_RB.position = new Vector2(Mathf.Clamp(player_RB.position.x, min, max), player_RB.position.y);
    }
}
