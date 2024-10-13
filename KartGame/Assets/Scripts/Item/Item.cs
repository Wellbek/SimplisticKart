using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{
    public enum Type
    {
        Boost,
        Spike,
    }

    public string Name;
    public Type type;
    public string description;
    public int uses;

    public ItemBoostFunction[] boost;
    public GameObject spikePrefab;

    public Sprite visual;
}
