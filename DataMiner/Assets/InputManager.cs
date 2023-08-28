using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;
using System;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine.Rendering.Universal;

public class InputManager : MonoBehaviour
{
    [Header("Inputs")]
    public GameObject inputField;
    public TMP_InputField InputField;
    public string[] ipAdresses;
    public GameObject[] ipComputers;
    public GameObject hackingShip;
    public GameObject camera;
    public GameObject player;
    public int[] informationBitsNeeded;
    public int neededinformationBits;
    public int informationBits;
    public int[] locationBitsNeeded;
    public int neededlocationBits;
    public int locationBits;

    public int i;
    public int oldi;

    [Header("Computer")]
    public GameObject Canvas;
    public GameObject Wallpaper;
    public GameObject Mail;
    public GameObject TaskBar;
    public GameObject Browser1;
    public GameObject Browser2;
    public GameObject PrivateMessages;
    public GameObject CommandPrompt;

    public Light2D globalLight;

    // Start is called before the first frame update
    void Start()
    {
        ipAdresses = gameObject.GetComponent<IPInformationManager>().IPAddresses;
        ipComputers = gameObject.GetComponent <IPInformationManager>().IPComputers;
    }

    // Update is called once per frame
    void Update()
    {
        locationBits = player.GetComponent<Movement>().collectedLocBits;
        informationBits = player.GetComponent<Movement>().collectedInfoBits;

        if (locationBits == neededlocationBits || informationBits == neededinformationBits || informationBits == neededinformationBits && locationBits == neededlocationBits)
        {
            Canvas.SetActive(true);
            Wallpaper.SetActive(true);
            TaskBar.SetActive(true);

            i += 1;
        }
    }

    public void InputChecker()
    {
        int SameWords = Array.IndexOf(ipAdresses, InputField.text);
        ipComputers[SameWords].SetActive(true);
        Canvas.SetActive(false);
        Wallpaper.SetActive(false);
        Mail.SetActive(false);
        TaskBar.SetActive(false);
        Browser1.SetActive(false);
        Browser2.SetActive(false);
        PrivateMessages.SetActive(false);
        CommandPrompt.SetActive(false);
        hackingShip.SetActive(true);
        camera.SetActive(true);
        neededinformationBits = informationBitsNeeded[SameWords];
        neededlocationBits = locationBitsNeeded[SameWords];
        globalLight.intensity = 0.5f;
    }
}
