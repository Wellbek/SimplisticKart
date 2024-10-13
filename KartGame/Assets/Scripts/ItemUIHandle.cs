using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemUIHandle : MonoBehaviour
{
    private bool shuffleSprite; //if the handle should shuffle between sprite images
    public float timeBtwShuffle; //how long between each image shuffle
    public Sprite[] allItemGraphics; //to cycle through when an item is being selected
    public Sprite emptyItem; //graphic for no item

    public Image img; //what image to change

    private KartItem kart; //the karts current item

    private void Start()
    {
        var players = GameObject.FindGameObjectsWithTag("Player");
        for (int i = 0; i < players.Length; i++)
        {
            if (players[i].GetComponent<Index>().index == GetComponentInParent<Index>().index) 
            {
                kart = players[i].GetComponent<KartItem>();
            }
        }

        shuffleSprite = true;
    }

    private void Update()
    {
        if (kart == null) return;
        if (kart.heldItem == -1)
        {
            if (kart.canPickup)
            {
                //no item is held, no image will be shown
                img.sprite = emptyItem;
            }
            else
            {
                //cycle through all item graphics
                if (shuffleSprite){
                    Invoke("Shuffle", timeBtwShuffle);
                    shuffleSprite = false;
                }
            }
        }
        else
        {
            img.sprite = kart.itemUse.visual;
        }
    }

    void Shuffle()
    {
        img.sprite = allItemGraphics[Random.Range(0, allItemGraphics.Length)];
        shuffleSprite = true;
    }
}
