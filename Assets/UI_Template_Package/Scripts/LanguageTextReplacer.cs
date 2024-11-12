using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class LanguageTextReplacer : MonoBehaviour
{
    public List<TextMeshProUGUI> textElements;
    public List<string> engText;
    public List<string> espText;

    void Start()
    {
        //gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        List<string> text;
        switch (GlobalVariables.LanguagePref)
        {
            case 0:
                text = engText;
                break;
            case 1:
                text = espText;
                break;
            default:
                text = engText;
                break;
        }
        for(int i = 0; i < textElements.Count(); i++)
        {
            string tempText = text[i].Replace(@"\n", "\n");
            tempText = tempText.Replace(@"\u2022", "\u2022");
            tempText = tempText.Replace(@"\u25e6", "\u25e6");
            tempText = tempText.Replace(@"\u2014", "\u2014");
            textElements[i].text = tempText;
        }
    }
}
