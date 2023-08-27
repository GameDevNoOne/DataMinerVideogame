using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedBitsHandler : MonoBehaviour
{
    public int infoBitsCollected;
    public int locBitsCollected;

    public GameObject infoBits;
    public GameObject locBits;

    public void Update()
    {
        infoBitsCollected = infoBits.GetComponent<CollisionDetection>().infocollected;
        locBitsCollected = locBits.GetComponent<CollisionDetection>().loccollected;
    }
}
