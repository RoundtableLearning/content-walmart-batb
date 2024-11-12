using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CCTextScroller : MonoBehaviour
{
    private const int VISIBLE_LINES = 5;

    private TextMeshProUGUI _textbox;
    private Vector2 _initialPos;
    private RectTransform _rectTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        _textbox = GetComponentInChildren<TextMeshProUGUI>();
        _rectTransform = GetComponent<RectTransform>();
        _initialPos = _rectTransform.anchoredPosition;
    }

    public void SetScrollingText(string text, float speed)
    {
        StopAllCoroutines();
        _rectTransform.anchoredPosition = _initialPos;
        _textbox.alignment = TextAlignmentOptions.Midline;
        _textbox.text = text;
        StartCoroutine(ScrollText(text, speed));
    }

    private IEnumerator ScrollText(string text, float speed)
    {
        var canvas = GetComponentInParent<Canvas>();
        canvas.enabled = true;
        Canvas.ForceUpdateCanvases();
        int linesToMove = _textbox.textInfo.lineCount - VISIBLE_LINES+1;
        canvas.enabled = LanguageManager.instance.showClosedCaptioning;

        if (linesToMove > 0)
        {
            _textbox.alignment = TextAlignmentOptions.Top;
            yield return new WaitForSeconds(2.4f);

            float distanceToMove = linesToMove * 33f; //33 is roughly the height of one line
            float distanceMoved = 0;
            
            while (distanceMoved < distanceToMove)
            {
                _rectTransform.anchoredPosition += new Vector2(0, speed);
                distanceMoved += speed;
                yield return new WaitForSeconds(0.05f);
            }
        }
    }

}
