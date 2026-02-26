using UnityEngine;
using UnityEngine.SceneManagement;

public class Salchicha : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int bloquesRestantes = GameObject.FindGameObjectsWithTag("Block").Length;
        string Escena_actual = SceneManager.GetActiveScene().name;

        if (bloquesRestantes == 0)
        {
            if (Escena_actual == "Level1")
            {
                SceneManager.LoadScene("Level2");
            }
            else if (Escena_actual == "Level2")
            {
                SceneManager.LoadScene("Level3");
            }
            else
            {
                SceneManager.LoadScene("Level_complete");
            }
        }
    }
}