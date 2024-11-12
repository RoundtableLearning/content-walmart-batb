using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RTL_UI_MainMenu : MonoBehaviour
{
    [System.Serializable]
    public struct ButtonImages
    {
        public Sprite Logo;
        public Sprite Button_Normal;
        public Sprite Butotn_Hover;
        public Sprite Button_Pressed;
      
    }

    private SpriteState _SpriteState;
    public ButtonImages[] _ButtonImages;

    public Button SafetLifting_Button, PalletHandling_Button, Lydia_Button, Safety_Button, OrderFiller_Button, Exit_Button;
    public Image SafetLifting_Image, PalletHandling_Image, Lydia_Image, Safety_Image, OrderFiller_Image, Exit_Image, Logo;

    private void Start()
    {

        _SpriteState = new SpriteState();
        if (_ButtonImages.Length > 0)
        {
            switch (RTL_UI_GlobalVariables._TargetCompany)
            {
                case RTL_UI_GlobalVariables.TargetCompany.Walmart:
                    Logo.sprite = _ButtonImages[0].Logo;

                    SafetLifting_Image.sprite = _ButtonImages[0].Button_Normal;
                    _SpriteState.highlightedSprite = _ButtonImages[0].Butotn_Hover;
                    _SpriteState.pressedSprite = _ButtonImages[0].Button_Pressed;
                    SafetLifting_Button.spriteState = _SpriteState;

                    PalletHandling_Image.sprite = _ButtonImages[0].Button_Normal;
                    _SpriteState.highlightedSprite = _ButtonImages[0].Butotn_Hover;
                    _SpriteState.pressedSprite = _ButtonImages[0].Button_Pressed;
                    PalletHandling_Button.spriteState = _SpriteState;

                    Lydia_Image.sprite = _ButtonImages[0].Button_Normal;
                    _SpriteState.highlightedSprite = _ButtonImages[0].Butotn_Hover;
                    _SpriteState.pressedSprite = _ButtonImages[0].Button_Pressed;
                    Lydia_Button.spriteState = _SpriteState;

                    Safety_Image.sprite = _ButtonImages[0].Button_Normal;
                    _SpriteState.highlightedSprite = _ButtonImages[0].Butotn_Hover;
                    _SpriteState.pressedSprite = _ButtonImages[0].Button_Pressed;
                    Safety_Button.spriteState = _SpriteState;

                    OrderFiller_Image.sprite = _ButtonImages[0].Button_Normal;
                    _SpriteState.highlightedSprite = _ButtonImages[0].Butotn_Hover;
                    _SpriteState.pressedSprite = _ButtonImages[0].Button_Pressed;
                    OrderFiller_Button.spriteState = _SpriteState;

                    Exit_Image.sprite = _ButtonImages[0].Button_Normal;
                    _SpriteState.highlightedSprite = _ButtonImages[0].Butotn_Hover;
                    _SpriteState.pressedSprite = _ButtonImages[0].Button_Pressed;
                    Exit_Button.spriteState = _SpriteState;
                    break;
                case RTL_UI_GlobalVariables.TargetCompany.Sams:
                    Logo.sprite = _ButtonImages[1].Logo;

                    SafetLifting_Image.sprite = _ButtonImages[1].Button_Normal;
                    _SpriteState.highlightedSprite = _ButtonImages[1].Butotn_Hover;
                    _SpriteState.pressedSprite = _ButtonImages[0].Button_Pressed;
                    SafetLifting_Button.spriteState = _SpriteState;

                    PalletHandling_Image.sprite = _ButtonImages[1].Button_Normal;
                    _SpriteState.highlightedSprite = _ButtonImages[1].Butotn_Hover;
                    _SpriteState.pressedSprite = _ButtonImages[0].Button_Pressed;
                    PalletHandling_Button.spriteState = _SpriteState;

                    Lydia_Image.sprite = _ButtonImages[1].Button_Normal;
                    _SpriteState.highlightedSprite = _ButtonImages[1].Butotn_Hover;
                    _SpriteState.pressedSprite = _ButtonImages[0].Button_Pressed;
                    Lydia_Button.spriteState = _SpriteState;

                    Safety_Image.sprite = _ButtonImages[1].Button_Normal;
                    _SpriteState.highlightedSprite = _ButtonImages[1].Butotn_Hover;
                    _SpriteState.pressedSprite = _ButtonImages[0].Button_Pressed;
                    Safety_Button.spriteState = _SpriteState;

                    OrderFiller_Image.sprite = _ButtonImages[1].Button_Normal;
                    _SpriteState.highlightedSprite = _ButtonImages[1].Butotn_Hover;
                    _SpriteState.pressedSprite = _ButtonImages[0].Button_Pressed;
                    OrderFiller_Button.spriteState = _SpriteState;

                    Exit_Image.sprite = _ButtonImages[1].Button_Normal;
                    _SpriteState.highlightedSprite = _ButtonImages[1].Butotn_Hover;
                    _SpriteState.pressedSprite = _ButtonImages[0].Button_Pressed;
                    Exit_Button.spriteState = _SpriteState;
                    break;
                default:
                    break;
            }
        }
    }

}
