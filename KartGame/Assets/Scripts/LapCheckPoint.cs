using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapCheckPoint : MonoBehaviour
{
    public int index; //Checkpoint index of order of track

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<KartLap>())
        {
            KartLap kart = other.GetComponentInParent<KartLap>();

            if (kart.checkpointIndex == index - 1)
            {
                kart.checkpointIndex = index;
                if (GameObject.FindGameObjectWithTag("GameController").GetComponent<PositionSystem>()) GameObject.FindGameObjectWithTag("GameController").GetComponent<PositionSystem>().UpdatePositions(kart.gameObject.GetComponent<Index>().index);
            }
        }
    }
}
