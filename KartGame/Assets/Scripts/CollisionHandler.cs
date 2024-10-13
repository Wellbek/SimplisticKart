using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void Awake()
    {
        Physics.IgnoreLayerCollision(10, 11); //ignore collision between KartColliders (for counting laps and checkpoints) and spherecollider (movement)
        Physics.IgnoreLayerCollision(8, 11); //ignore collision between KartColliders (for counting laps and checkpoints) and ground
        Physics.IgnoreLayerCollision(11, 11); //ignore collision between KartColliders (for counting laps and checkpoints)
    }
}
