using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class PositionSystem : MonoBehaviour
{
    private Position[] positions;
    private GameObject[] players;

    public Text[] positionTexts;
    public TextMeshProUGUI[] endTexts;

    void Start()
    {
        StartCoroutine(LateStart(.1f));
    }

    IEnumerator LateStart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        players = GameObject.FindGameObjectsWithTag("Player");
        positions = new Position[players.Length];

        SortPlayers();

        //At start Player of index 0 will be first place and player of index 2 second place and so on
        for (int i = 0; i < players.Length; i++)
        {
            positions[i] = new Position(i, players[i]);
        }
        UpdateGUI();
    }

    //Sort players according to their index
    void SortPlayers()
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

    public void UpdatePositions(int player)
    {
        //Debug.Log("trying to update...");
        for (int i = 0; i < players.Length; i++)
        {
            if (positions[i].GetPosition() >= GetPlayerPosition(player))
            {
                //Debug.Log("Nothing to update");
                return;
            }
            if (positions[i].GetPlayer().GetComponent<KartLap>().lapNumber < players[player].GetComponent<KartLap>().lapNumber 
                || (positions[i].GetPlayer().GetComponent<KartLap>().lapNumber == players[player].GetComponent<KartLap>().lapNumber 
                && positions[i].GetPlayer().GetComponent<KartLap>().checkpointIndex < players[player].GetComponent<KartLap>().checkpointIndex))
            {
                //Swap positions and check again with swapped player 
                var myPos = GetPlayerPosition(player);
                var tmp = positions[i].GetPlayer();
                positions[i].SetPlayer(players[player]);
                positions[myPos].SetPlayer(tmp);
                UpdateGUI();
                //Debug.Log("Successful update!");
                UpdatePositions(tmp.GetComponent<Index>().index); //REVIEW: is that actually needed?
            }
            //else Debug.Log("fail");
        }
    }

    public int GetPlayerPosition(int index)
    {
        for (int i = 0; i < players.Length; i++)
        {
            if (positions[i].GetPlayer() == players[index]) return positions[i].GetPosition();
        }
        Debug.LogError("PLAYER COULD NOT BE FOUND!");
        return -1;
    }

    private void UpdateGUI()
    {
        for (int i = 0; i < players.Length; i++)
        {
            positionTexts[i].text = (GetPlayerPosition(i) + 1).ToString();
            
            switch (i)
            {
                case 0:
                    {
                        endTexts[i].text = ("FIRST PLACE: PLAYER " + (positions[i].GetPlayer().GetComponent<Index>().index + 1).ToString());
                        if (!endTexts[i].gameObject.activeSelf) endTexts[i].gameObject.SetActive(true);
                        break;
                    }
                case 1:
                    {
                        endTexts[i].text = ("SECOND PLACE: PLAYER " + (positions[i].GetPlayer().GetComponent<Index>().index + 1).ToString());
                        if (!endTexts[i].gameObject.activeSelf) endTexts[i].gameObject.SetActive(true);
                        break;
                    }
                case 2:
                    {
                        endTexts[i].text = ("THIRD PLACE: PLAYER " + (positions[i].GetPlayer().GetComponent<Index>().index + 1).ToString());
                        if (!endTexts[i].gameObject.activeSelf) endTexts[i].gameObject.SetActive(true);
                        break;
                    }
                case 3:
                    {
                        endTexts[i].text = ("FOURTH PLACE: PLAYER " + (positions[i].GetPlayer().GetComponent<Index>().index + 1).ToString());
                        if (!endTexts[i].gameObject.activeSelf) endTexts[i].gameObject.SetActive(true);
                        break;
                    }
            }
        }
    }
}

public class Position
{
    public Position(int pos, GameObject player)
    {
        position = pos;
        this.player = player;
    }
    private int position;
    private GameObject player;

    public int GetPosition()
    {
        return position;
    }

    public GameObject GetPlayer()
    {
        return player;
    }

    public void SetPlayer(GameObject player)
    {
        this.player = player;
    }
}
