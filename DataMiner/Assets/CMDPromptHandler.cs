using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMDPromptHandler : MonoBehaviour
{
    public GameObject prompt;

    public void OpenPrompt()
    {
        prompt.SetActive(true);
    }

    public void ClosePrompt()
    {
        prompt.SetActive(false);
    }
}
