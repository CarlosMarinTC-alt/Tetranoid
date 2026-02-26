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
        if (Input.anyKeyDown)
        {
            string Escena_actual = SceneManager.GetActiveScene().name;

            if (Escena_actual == "Game_Over")
            {

                SceneManager.LoadScene("Title");
            }

            else if(Escena_actual == "Level_complete")
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
