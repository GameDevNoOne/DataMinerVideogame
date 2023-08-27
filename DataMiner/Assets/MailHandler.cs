using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering.Universal;

public class MailHandler : MonoBehaviour
{
    public GameObject Mail;
    public GameObject IPComputer;

    public TextMeshProUGUI IPAddress;
    public TextMeshProUGUI Email;
    public TextMeshProUGUI Address;
    public TextMeshProUGUI Sender;

    public string IP;
    public string MailWords;
    public string Header;
    public string sender;

    public int i;

    public void OpenMail()
    {
        Mail.SetActive(true);
    }

    public void CloseMail()
    {
        Mail.SetActive(false);
    }

    public void Update()
    {
        IP = gameObject.GetComponent<MailInformation>().IPAddress[i];
        MailWords = gameObject.GetComponent<MailInformation>().mail[i];
        Header = gameObject.GetComponent<MailInformation>().header[i];
        sender = gameObject.GetComponent<MailInformation>().sender[i];

        IPAddress.text = IP;
        Email.text = MailWords;
        Address.text = Header;
        Sender.text = sender;

        i = IPComputer.GetComponent<InputManager>().i;
    }


}
