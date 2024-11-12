using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using RTL.Atlas;

public class StartScreen_Controller : MonoBehaviour
{
    public Button EnglishButton;
    public Button SpanishButton;
    public Button StartButton;

    public TextMeshProUGUI BodyText;
    public TextMeshProUGUI ButtonText;

    public MainMenuSceneSequence _MainMenuSequence;
    public GameObject LanguageScreen, InstructionScreen, MainMenuCanvas;
    private void Start()
    {
        EnglishButton.onClick.AddListener(() => ButtonPressed(0));
        SpanishButton.onClick.AddListener(() => ButtonPressed(1));
        StartButton.onClick.AddListener(() => { InstructionScreen.SetActive(false);MainMenuCanvas.SetActive(true);StartButton.onClick.RemoveAllListeners(); });
    }

    void ButtonPressed(int buttonNum)
    {
        EnglishButton.onClick.RemoveAllListeners();
        SpanishButton.onClick.RemoveAllListeners();

        _MainMenuSequence.selectLanguage(buttonNum);
        switch (buttonNum)
        {
            case 0://english
                BodyText.text = "Welcome! Before you begin this experience, make sure you have your floor and boundary set up correctly.\r\n\r\nSelect the continue button when you are ready.";
                ButtonText.text = "Continue";
                break;
            case 1://spanish
                BodyText.text = "¡Bienvenido! Antes de comenzar esta experiencia, asegúrese de tener el piso y los límites configurados correctamente.\r\n\r\nSeleccione el botón Continuar cuando esté listo.";
                ButtonText.text = "Continuar";
                break;
            default:
                break;
        }
        LanguageScreen.SetActive(false);
        InstructionScreen.SetActive(true);
    }
    
}
