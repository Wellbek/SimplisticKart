using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.XR.OpenVR;
using UnityEngine;

public class KartItem : MonoBehaviour
{
    private CarController kart;
    private GameItemsHandle handle;

    public Transform itemDropPoint;

    public float delayBeforeItemPickup = 1;//time between picking up an item and being able to use it

    public int heldItem; //0 equals null

    public bool canPickup; // if player can pickup an item
    private bool useItem; //if player is pressing the use item button

    public Item itemUse; //the current held item
    private int remainingItemUses; //how many times the item can still be used

    private Item.Type type; //type of current item

    private void Start()
    {
        handle = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameItemsHandle>();

        kart = GetComponent<CarController>();

        type = Item.Type.Boost;

        ResetItem();
    }

    private void Update()
    {
        if (useItem && heldItem != -1)
        {
            useItem = false;
            ActivateItem();
        }
    }

    public void StartPickup()
    {
        StartCoroutine(PickUp());
    }

    public IEnumerator PickUp()
    {
        if (heldItem == -1 && canPickup)
        {
            canPickup = false;
            
            //play pickup animation

            yield return new WaitForSeconds(delayBeforeItemPickup);
            
            //chose a held items
            int randItem = Random.Range(0, handle.allItems.Length);

            itemUse = handle.allItems[randItem];

            heldItem = randItem;
            remainingItemUses = itemUse.uses;

            type = itemUse.type;
        }
    }

    public void ActivateItem()
    {
        remainingItemUses -= 1;

        switch (type)
        {
            case Item.Type.Boost:
                {
                    if (itemUse.boost.Length > 0)
                    {
                        foreach (ItemBoostFunction itemBoost in itemUse.boost)
                        {
                            //increases the car velocity by x (first parameter) for y (second parameter) seconds
                            kart.ItemBoost(1.5f, 1.5f);
                        }
                    }
                    break;
                }
            case Item.Type.Spike:
                {
                    Instantiate(itemUse.spikePrefab, itemDropPoint.position, itemDropPoint.rotation);
                    break;
                }
        }

        if (remainingItemUses <= 0)
        {
            //this item is used up, reset values
            ResetItem();
        }
    }

    //resetting item values on start
    public void ResetItem()
    {
        itemUse = null;
        heldItem = -1; //-1 since -1 is not a valid index in GameItemsHandle's allItems list
        canPickup = true;
    }

    public void SetUseItem(bool state)
    {
        useItem = state;
    }
}
