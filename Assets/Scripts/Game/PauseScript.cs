using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{

    public GameObject pauseMenu;
    void Update()
    {

        {
            if (Input.GetKeyDown(KeyCode.Escape))

                if (!pauseMenu.activeSelf)
                {
                    pauseMenu.SetActive(true);
                    Time.timeScale = 0f;
                }
                else
                {
                    pauseMenu.SetActive(false);
                    Time.timeScale = 1f;
                }

        }
    }

    public void resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
