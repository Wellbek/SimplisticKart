using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    public GameObject pauseMenu, pauseMenuFirstButton;
    public GameObject optionsMenu, optionsMenuFirstButton;

    private void Awake()
    {
        instance = this;
    }

    public void ChangeToScene(string sceneName)
    {
        EventSystem.current.SetSelectedGameObject(null);
        SceneManager.LoadScene(sceneName);
    }

    public void OpenOptionsMenu()
    {
        optionsMenu.SetActive(true);
        EventSystem.current.SetSelectedGameObject(optionsMenuFirstButton);
    }

    public void CloseOptionsMenu()
    {
        EventSystem.current.SetSelectedGameObject(pauseMenuFirstButton);
        optionsMenu.SetActive(false);
    }

    public void OpenPauseMenu()
    {
        pauseMenu.SetActive(true);
        EventSystem.current.SetSelectedGameObject(pauseMenuFirstButton);
        GameController.instance.gamePlaying = false;
        if (TimerController.instance != null)
            TimerController.instance.PauseTimer();
    }

    public void ClosePauseMenu()
    {
        if (optionsMenu.activeSelf) CloseOptionsMenu();
        EventSystem.current.SetSelectedGameObject(null);
        pauseMenu.SetActive(false);
        GameController.instance.gamePlaying = true;
        if (TimerController.instance != null)
            TimerController.instance.ResumeTimer();
    }

    //player input
    private void OnPauseGame()
    {
        if (pauseMenu.activeSelf) ClosePauseMenu();
        else OpenPauseMenu();
    }
}
