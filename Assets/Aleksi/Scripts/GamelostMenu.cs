using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamelostMenu : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void ControlsMenu()
    {

    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
