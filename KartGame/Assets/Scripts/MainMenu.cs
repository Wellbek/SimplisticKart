using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    public GameObject optionsMenu;

    public GameObject mainMenuFirstButton, optionsMenuFirstButton;

    private void Start()
    {
        //Destroying all left over PlayerConfigurationManagers which are not being needed in main menu and will led to singleton errors but exist since they don't destroy on scene load because of player setup
        var pConfigManagers = GameObject.FindGameObjectsWithTag("PlayerConfigurationManager");
        foreach (GameObject g in pConfigManagers) Destroy(g);
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
        optionsMenu.SetActive(false);
        EventSystem.current.SetSelectedGameObject(mainMenuFirstButton);
    }

    public void QuitGame()
    {
        EventSystem.current.SetSelectedGameObject(null);
        Application.Quit();
    }
}
