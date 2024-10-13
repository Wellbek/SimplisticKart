using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KartLap : MonoBehaviour
{
    private Text lapText;

    public int lapNumber;
    public int checkpointIndex;

    private void Awake()
    {
        lapNumber = 1;
        checkpointIndex = 0;
    }

    private void Start()
    {
        var pGUIs = GameObject.FindGameObjectsWithTag("PlayerGUI");
        Debug.Log(pGUIs.Length);
        for (int i = 0; i < pGUIs.Length; i++)
        {
            //only saving and manipulating the Text that corresponds to the player
            if (pGUIs[i].gameObject.GetComponent<Index>().index == gameObject.GetComponent<Index>().index)
            {
                lapText = pGUIs[i].transform.Find("LapCountText").GetComponent<Text>();
            }
        }
    }

    public void UpdateLapState()
    {
        if (lapNumber > GameController.instance.getLapAmount())
        {
            GameController.instance.ShowEndScreen(gameObject.GetComponent<Index>().index);
            if (TimerController.instance != null) TimerController.instance.EndTimer();
        }
        else lapText.text = "LAP: " + lapNumber + "/" + GameController.instance.getLapAmount();
    }
}
