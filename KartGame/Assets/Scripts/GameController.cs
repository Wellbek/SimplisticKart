using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class GameController : MonoBehaviour
{
    public enum Type
    {
        TimeRace,
        LocalMultiplayer,
    }

    public Type type;

    public static GameController instance;
    public bool gamePlaying = false;

    public int lapAmount;

    public TextMeshProUGUI[] endTexts;
    public GameObject[] endScreens;
    public GameObject LMFinalScreen;
    public GameObject endScreenButton;

    private GameObject[] players;

    private void Awake()
    {
        instance = this;
        gamePlaying = false;
    }

    void Start()
    {
        StartCoroutine(LateStart(.1f));
    }

    IEnumerator LateStart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        players = GameObject.FindGameObjectsWithTag("Player");

        //Sort players based of their index
        if (players.Length > 1)
        {
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i].GetComponent<Index>().index != i)
                {
                    var tmp = players[players[i].GetComponent<Index>().index];
                    players[players[i].GetComponent<Index>().index] = players[i];
                    players[i] = tmp;
                    i--;
                }
            }
        }
    }

    public void BeginGame()
    {
        gamePlaying = true;
        if (TimerController.instance != null)
            TimerController.instance.BeginTimer();
    }

    public void ShowEndScreen(int playerIndex)
    {
        players[playerIndex].SetActive(false);
        switch (type)
        {
            case Type.TimeRace:
                {
                    endTexts[playerIndex].text = gameObject.GetComponent<TimerController>().timerCounter.text;
                    endScreens[playerIndex].SetActive(true);
                    EventSystem.current.SetSelectedGameObject(endScreenButton);
                    break;
                }
            case Type.LocalMultiplayer:
                {
                    endTexts[playerIndex].text = gameObject.GetComponent<PositionSystem>().positionTexts[playerIndex].text;
                    endScreens[playerIndex].SetActive(true);
                    //check if every player has finished
                    for (int i = 0; i < players.Length; i++)
                    {
                        if (!endScreens[i].activeSelf) return;
                    }
                    LMFinalScreen.SetActive(true);
                    EventSystem.current.SetSelectedGameObject(endScreenButton);
                    break;
                }
        }
    }

    public int getLapAmount()
    {
        return lapAmount;
    }
}
