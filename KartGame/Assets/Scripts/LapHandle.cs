using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapHandle : MonoBehaviour
{
    public int checkpointAmt; //Amount of checkpoints on track

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<KartLap>())
        {
            KartLap kart = other.GetComponentInParent<KartLap>();

            if (kart.checkpointIndex == checkpointAmt)
            {
                //the kart reached the final checkpoint

                //reset the karts checkpoint index and finish the lap
                kart.checkpointIndex = 0;
                kart.lapNumber++;
                kart.UpdateLapState();
                if (GameObject.FindGameObjectWithTag("GameController").GetComponent<PositionSystem>()) GameObject.FindGameObjectWithTag("GameController").GetComponent<PositionSystem>().UpdatePositions(kart.gameObject.GetComponent<Index>().index);
            }
        }
    }
}
