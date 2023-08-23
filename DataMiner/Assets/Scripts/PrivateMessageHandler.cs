using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrivateMessageHandler : MonoBehaviour
{
    public GameObject Discord;

    public void QuitDiscord()
    {
        Discord.SetActive(false);
    }

    public void OpenDiscord()
    {
        Discord.SetActive(true);
    }
}
