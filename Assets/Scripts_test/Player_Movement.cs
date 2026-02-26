using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float velocidad = 5.5f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola Mundo!" + velocidad);
    }

    // Update is called once per frame
    void Update()
    {
        float velocidadX = Input.GetAxis("Horizontal")*Time.deltaTime*velocidad;

        Vector3 position = transform.position;

        transform.position = new Vector3(velocidadX + position.x, position.y, position.z);
    }
}
