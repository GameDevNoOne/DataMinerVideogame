using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Powers : MonoBehaviour
{

    public bool stateFire;
    public bool stateElectricity;
    public bool stateGravity;
    public bool basicState;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("StateFire"))
        {
            stateFire = true;
            stateElectricity = false;
            stateGravity = false;
            basicState = false;
        }
        if (Input.GetButtonDown("StateElectricity"))
        {
            stateElectricity = true;
            stateGravity = false;
            stateFire = false;
            basicState = false;
        }
        if (Input.GetButtonDown("StateGravity"))
        {
            stateGravity = true;
            stateElectricity = false;
            stateFire = false;
            basicState=false;
        }
        if (Input.GetButtonDown("BasicState"))
        {
            basicState = true;
            stateElectricity=false;
            stateFire=false;
            stateGravity = false;
        }
    }
}
