using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class RTL_UI_InGameMenu : MonoBehaviour
{
    [System.Serializable]
    public struct ButtonImages
    {
        public Sprite CCButtonImage_Normal;
        public Sprite CCButtonImage_Hover;
        public Sprite ExitCourseImage_Normal;
        public Sprite ExitCourseImage_Hover;
        public Sprite CloseImage_Normal;
        public Sprite CloseImage_Hover;
    }

   
    public ButtonImages[] _ButtonImages;

    public Button CCButton, ExitButton, CloseButton;
    public Image CCButtonImage, ExitButtonImage,CloseButtonImage;

    private SpriteState _SpriteState;
    private void Start()
    {
       
        _SpriteState = new SpriteState();
        if (_ButtonImages.Length > 0)
        {
            switch (RTL_UI_GlobalVariables._TargetCompany)
            {
                case RTL_UI_GlobalVariables.TargetCompany.Walmart:
                    CCButtonImage.sprite = _ButtonImages[0].CCButtonImage_Normal;
                    _SpriteState.highlightedSprite = _ButtonImages[0].CCButtonImage_Hover;
                    CCButton.spriteState = _SpriteState;

                    ExitButtonImage.sprite = _ButtonImages[0].ExitCourseImage_Normal;
                    _SpriteState.highlightedSprite = _ButtonImages[0].ExitCourseImage_Hover;
                    ExitButton.spriteState = _SpriteState;

                    CloseButtonImage.sprite = _ButtonImages[0].CloseImage_Normal;
                    _SpriteState.highlightedSprite = _ButtonImages[0].CloseImage_Hover;
                    ExitButton.spriteState = _SpriteState;

                    break;
                case RTL_UI_GlobalVariables.TargetCompany.Sams:
                    CCButtonImage.sprite = _ButtonImages[1].CCButtonImage_Normal;
                    _SpriteState.highlightedSprite = _ButtonImages[1].CCButtonImage_Hover;
                    CCButton.spriteState = _SpriteState;

                    ExitButtonImage.sprite = _ButtonImages[1].ExitCourseImage_Normal;
                    _SpriteState.highlightedSprite = _ButtonImages[1].ExitCourseImage_Hover;
                    ExitButton.spriteState = _SpriteState;

                    CloseButtonImage.sprite = _ButtonImages[1].CloseImage_Normal;
                    _SpriteState.highlightedSprite = _ButtonImages[1].CloseImage_Hover;
                    ExitButton.spriteState = _SpriteState;
                    break;
                default:
                    break;
            }
        }
    }


    public InputActionReference menuButtonReference = null;
    public GameObject InGameMenu;
    private void Awake()
    {
        menuButtonReference.action.started += Toggle;
    }
    private void OnDestroy()
    {
        menuButtonReference.action.started -= Toggle;
    }
    private void Toggle(InputAction.CallbackContext context)
    {
        bool isActive = !InGameMenu.activeSelf;
        InGameMenu.SetActive(isActive);
    }

    public void ChangeScene(int sceneIndex)
    {
        Fader.instance.dimmerObj.SetActive(true);
        Fader.instance.dimmerObj.GetComponent<Dimmer>().Fade(true, 1f);
        StartCoroutine(DelayedLoadScene(sceneIndex, 2f));
    }

    IEnumerator DelayedLoadScene(int sceneIndex, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadSceneAsync(sceneIndex, LoadSceneMode.Single);
    }

    public void ToggleCCButton()
    { 
        LanguageManager.instance.showClosedCaptioning = !LanguageManager.instance.showClosedCaptioning;
        ClosedCaptioning.canvas.enabled =LanguageManager.instance.showClosedCaptioning;
    }
}
