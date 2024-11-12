using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class RTL_UI_SwitchImage : MonoBehaviour
{
    [SerializeField] private List<Image> images;
    [SerializeField] private List<Sprite> walmartImages;
    [SerializeField] private List<Sprite> samsImages;

    [SerializeField] private List<Image> Logos;
    [SerializeField] private List<Button> Buttons;

    [SerializeField] private Sprite Walmart_Logo;
    [SerializeField] private Sprite Sams_Logo;
    [SerializeField] private Sprite Walmart_Button_Normal;
    [SerializeField] private Sprite Walmart_Button_Highlight;
    [SerializeField] private Sprite Walmart_Button_Pressed;
    [SerializeField] private Sprite Sams_Button_Normal;
    [SerializeField] private Sprite Sams_Button_Highlight;
    [SerializeField] private Sprite Sams_Button_Pressed;

    private SpriteState _spriteState;
    void Start()
    {

 
        if(RTL_UI_GlobalVariables._TargetCompany == RTL_UI_GlobalVariables.TargetCompany.Walmart)
        {
            _spriteState.highlightedSprite = Walmart_Button_Highlight;
            _spriteState.pressedSprite = Walmart_Button_Pressed;
            for(int i = 0; i < images.Count; i++)
            {
                images[i].sprite = walmartImages[i];
            }
            for(int j = 0; j < Logos.Count;j++)
            {
                Logos[j].sprite = Walmart_Logo;
            }
            for (int k = 0; k < Buttons.Count; k++)
            {
                Buttons[k].GetComponent<Image>().sprite = Walmart_Button_Normal;
                Buttons[k].spriteState = _spriteState;
            }

        }
        else
        {
            _spriteState.highlightedSprite = Sams_Button_Highlight;
            _spriteState.pressedSprite = Sams_Button_Pressed;
            for (int i = 0; i < images.Count; i++)
            {
                images[i].sprite = samsImages[i];
            }
            for (int j = 0; j < Logos.Count; j++)
            {
                Logos[j].sprite = Sams_Logo;
            }
            for (int k = 0; k < Buttons.Count; k++)
            {
                Buttons[k].GetComponent<Image>().sprite = Sams_Button_Normal;
                Buttons[k].spriteState = _spriteState;
            }
        }
    }
}
