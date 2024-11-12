using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RTL.Atlas;
using UnityEngine.UI;
using TMPro;

[RequireComponent (typeof(Button))]
public class CCButtonStyleController : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private Sprite activeSprite;
    [SerializeField] private Sprite inactiveSprite;
    [SerializeField] private Color activeColor;
    [SerializeField] private Color inactiveColor;
    private Button btn;

    void Start()
    {
        btn = GetComponent<Button>();
    }

    void Update()
    {
        if(LanguageManager.instance.showClosedCaptioning)
        {
            btn.image.sprite = activeSprite;
            text.color = activeColor;
            return;
        }
        btn.image.sprite = inactiveSprite;
        text.color = inactiveColor;
    }
}
