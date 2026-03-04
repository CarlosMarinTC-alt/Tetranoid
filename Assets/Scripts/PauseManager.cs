using UnityEngine;

public class PauseManager : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        // Detecta la tecla Escape para alternar la pausa
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.JoystickButton7))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f; // Detiene el tiempo
        isPaused = true;
        // Aquí puedes activar tu panel de menú de pausa
        Debug.Log("Juego Pausado");
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f; // Reanuda el tiempo
        isPaused = false;
        // Aquí puedes desactivar tu panel de menú de pausa
        Debug.Log("Juego Reanudado");
    }
}
