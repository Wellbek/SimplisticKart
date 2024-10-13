using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerConfigurationManager : MonoBehaviour
{
    private List<PlayerConfiguration> playerConfigs;

    [SerializeField]
    private int MaxPlayers = 4;
    [SerializeField]
    private int MinPlayers = 2;

    public static PlayerConfigurationManager instance { get; private set; }

    public GameObject pressXToJoin;
    public string sceneName;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
            playerConfigs = new List<PlayerConfiguration>();
        }
        else Debug.LogError("SINGLETON - Trying to create antoher instance of singleton!!");
    }

    public void SetPlayerMaterial(int index, Material mat)
    {
        playerConfigs[index].PlayerMaterial = mat;
    }

    public void ReadyPlayer(int index)
    {
        playerConfigs[index].isReady = true;
        if (playerConfigs.Count >= MinPlayers && playerConfigs.Count <= MaxPlayers && playerConfigs.All(p => p.isReady == true))
        { 
            SceneManager.LoadScene(sceneName);
        }
    }

    public void HandlePlayerJoin(PlayerInput pi)
    {
        Debug.Log("Player joined" + pi.playerIndex);
        //making sure that the player has'nt already been added 
        if (!playerConfigs.Any(p => p.playerIndex == pi.playerIndex))
        {
            pi.transform.SetParent(transform);
            playerConfigs.Add(new PlayerConfiguration(pi));
            if (pressXToJoin.activeSelf) pressXToJoin.SetActive(false);
        }
    }

    public List<PlayerConfiguration> GetPlayerConfigs()
    {
        return playerConfigs;
    }
}

public class PlayerConfiguration
{
    public PlayerConfiguration(PlayerInput pi)
    {
        playerIndex = pi.playerIndex;
        input = pi;
    }
    public PlayerInput input { get; set; }
    public int playerIndex { get; set; }
    public bool isReady { get; set; }
    public Material PlayerMaterial { get; set; }
}
