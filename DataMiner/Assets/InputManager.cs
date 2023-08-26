using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;
using System;

public class InputManager : MonoBehaviour
{

    public GameObject inputField;
    public TMP_InputField InputField;
    public string[] ipAdresses;
    public GameObject[] ipComputers;

    // Start is called before the first frame update
    void Start()
    {
        ipAdresses = gameObject.GetComponent<IPInformationManager>().IPAddresses;
        ipComputers = gameObject.GetComponent <IPInformationManager>().IPComputers;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InputChecker()
    {
        int SameWords = Array.IndexOf(ipAdresses, InputField.text);
        ipComputers[SameWords].SetActive(true);
    }
}
