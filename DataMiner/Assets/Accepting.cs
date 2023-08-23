using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accepting : MonoBehaviour
{
    public GameObject Mail;
    public bool Accept;

    public void Accepted()
    {
        Accept = true;
    }
}
