using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1.0f;
    }
    
    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("Exet pressed");
    }
}
