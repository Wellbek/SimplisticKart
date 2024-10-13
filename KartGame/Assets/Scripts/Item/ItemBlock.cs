using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBlock : MonoBehaviour
{
    public GameObject itemBlockPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<KartItem>())
        {
            if (other.GetComponentInParent<KartItem>().heldItem == -1 && other.GetComponentInParent<KartItem>().canPickup)
            {
                //start the players kart item script

                other.GetComponentInParent<KartItem>().StartPickup();

                gameObject.SetActive(false);
                Invoke("Respawn", 10);
            }
        }
    }

    void Respawn()
    {
        GameObject itemBlock = (GameObject)Instantiate(itemBlockPrefab, transform.position, transform.rotation, this.transform.parent);
        itemBlock.SetActive(true);
        Destroy(this.gameObject);
    }
}
