using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

[RequireComponent (typeof(Button))]
public class ButtonChangeTextStyle : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    public TMP_Text text;
    [SerializeField] private Color normalColor = new Color(0.1019608f,0.4588235f,0.8078431f);
    [SerializeField] private Color selectColor = Color.white;
    [SerializeField] private Color pressedColor = new Color(0.1019608f,0.4588235f,0.8078431f);

    public void OnPointerEnter(PointerEventData eventData)
    {
        text.color = selectColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.color = normalColor;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        text.color = pressedColor;
    }
    public void OnPointerUp (PointerEventData eventData)
	{
		text.color = normalColor;
	}
    
}
