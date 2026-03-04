using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambiar_Escena : MonoBehaviour
{   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            string Escena_actual = SceneManager.GetActiveScene().name;

            if (Escena_actual == "Game_Over" || Escena_actual == "Level_complete")
            {

                SceneManager.LoadScene("Title");
            }

            else
            {
                SceneManager.LoadScene("Level1");
            }
        }
    }
}
