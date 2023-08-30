using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PMHandler : MonoBehaviour
{
    public GameObject Option1;
    public GameObject Option2;

    public string Answer1;
    public string Answer2;

    public string Choice1;
    public string Choice2;

    public TextMeshProUGUI Option;
    public TextMeshProUGUI OptionT;

    public TextMeshProUGUI Answer;
    public TextMeshProUGUI AnswerT;

    public int i;

    public void OpenChoices()
    {
        Option1.SetActive(true);
        Option2.SetActive(true);
    }

    public void CloseChoices()
    {
        Option1.SetActive(false);
        Option2.SetActive(false);
    }

    public void Update()
    {
        Choice1 = gameObject.GetComponent<PrivateMessageInformation>().Options1[i];
        Choice2 = gameObject.GetComponent<PrivateMessageInformation>().Options2[i];

        Option.text = Choice1;
        OptionT.text = Choice2;
    }
}
