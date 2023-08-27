using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BrowserHandler : MonoBehaviour
{
    public GameObject Chrome;
    public GameObject IP;

    public TextMeshProUGUI NewsArticle1;
    public TextMeshProUGUI NewsArticleName1;
    public TextMeshProUGUI NewsArticle2;
    public TextMeshProUGUI NewsArticleName2;
    public TextMeshProUGUI NewsArticle3;
    public TextMeshProUGUI NewsArticleName3;
    public TextMeshProUGUI NewsArticle4;
    public TextMeshProUGUI NewsArticleName4;

    public string NewsArticle;
    public string Title;
    public string NewsArticleT;
    public string TitleT;
    public string NewsArticleTr;
    public string TitleTr;
    public string NewsArticleF;
    public string TitleF;

    public int i;

    public void OpenChrome()
    {
        Chrome.SetActive(true);
    }

    public void QuitChrome()
    {
        Chrome.SetActive(false);
    }

    public void Update()
    {
        NewsArticle = gameObject.GetComponent<BrowserInformation>().Article1[i];
        Title = gameObject.GetComponent<BrowserInformation>().ArticleName1[i];
        NewsArticleT = gameObject.GetComponent<BrowserInformation>().Article2[i];
        TitleT = gameObject.GetComponent<BrowserInformation>().ArticleName2[i];
        NewsArticleTr = gameObject.GetComponent<BrowserInformation>().Article3[i];
        TitleTr = gameObject.GetComponent<BrowserInformation>().ArticleName3[i];
        NewsArticleF = gameObject.GetComponent<BrowserInformation>().Article4[i];
        TitleF = gameObject.GetComponent<BrowserInformation>().ArticleName4[i];

        NewsArticle1.text = NewsArticle;
        NewsArticleName1.text = Title;
        NewsArticle2.text = NewsArticleT;
        NewsArticleName2.text = TitleT;
        NewsArticle3.text = NewsArticleTr;
        NewsArticleName3.text = TitleTr;
        NewsArticle4.text = NewsArticleF;
        NewsArticleName4.text = TitleF;

        i = IP.GetComponent<InputManager>().i;
    }
}
