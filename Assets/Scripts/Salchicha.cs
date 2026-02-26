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

        if (bloquesRestantes == 0)
        {
            SceneManager.LoadScene("Level_complete");
        }
    }
}