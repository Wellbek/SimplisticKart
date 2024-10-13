using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InitializeLevel : MonoBehaviour
{

    //private variables
    [SerializeField]
    private Transform[] playerSpawns;
    [SerializeField]
    private GameObject playerPrefab;

    private GameObject[] playerObjects;
    private PlayerConfiguration[] playerConfigs;

    //public variables
    public GameObject[] playerGUIs;

    private void Start()
    {
        playerConfigs = PlayerConfigurationManager.instance.GetPlayerConfigs().ToArray();
        playerObjects = new GameObject[playerConfigs.Length];
        for (int i = 0; i < playerConfigs.Length; i++)
        {
            playerObjects[i] = Instantiate(playerPrefab, playerSpawns[i].position, playerSpawns[i].rotation, gameObject.transform);
            playerObjects[i].GetComponent<PlayerInputHandler>().InitializePlayer(playerConfigs[i]);
            playerObjects[i].GetComponent<Index>().index = i;
        }
        InitializeSplitscreen();
    }

    private void InitializeSplitscreen()
    {
        Camera[] cameras = new Camera[playerConfigs.Length];
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i] = playerObjects[i].GetComponentInChildren<Camera>();
        }
        switch (cameras.Length)
        {
            case 2:
                {
                    cameras[0].rect = new Rect(0, .5f, .5f, .5f);
                    cameras[1].rect = new Rect(.5f, .5f, .5f, .5f);
                    break;
                }
            case 3:
                {
                    cameras[0].rect = new Rect(0, .5f, .5f, .5f);
                    cameras[1].rect = new Rect(.5f, .5f, .5f, .5f);
                    cameras[2].rect = new Rect(0, 0, .5f, .5f);
                    break;
                }
            case 4:
                {
                    cameras[0].rect = new Rect(0, .5f, .5f, .5f);
                    cameras[1].rect = new Rect(.5f, .5f, .5f, .5f);
                    cameras[2].rect = new Rect(0, 0, .5f, .5f);
                    cameras[3].rect = new Rect(.5f, 0, .5f, .5f);
                    break;
                }
        }

        //activate the corresponding UI for each available player
        for (int i = 0; i < playerConfigs.Length; i++)
        {
            playerGUIs[i].SetActive(true);
        }
    }
}
