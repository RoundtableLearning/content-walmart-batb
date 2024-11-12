using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RTL.Atlas;

public class MainMenuSceneSequence : AbstractSceneSequence
{
   
    [SerializeField] private GameObject StartScreen;
    [SerializeField] private SceneLoader sceneLoader;
    [SerializeField] private GameObject mainMenuCanvas;

    private void Awake()
    {
       
       
    }
    protected override void Start()
    {
        base.Start();
    }

    public void selectLanguage(int language)
    {
        GlobalVariables.LanguagePref = language;
    }
   

    protected override void AddStates()
    {
        AddState(new FadeInSequence(4f));
        AddState(new ActionState(() => {
            if (GlobalVariables.firstRunComplete == false)
            {
                GlobalVariables.firstRunComplete = true;
                StartScreen.SetActive(true);
            }
            else
            {
                mainMenuCanvas.SetActive(true);
            }
        
        
        }));
        AddState(new TriggerState("start"));
        AddState(new ActionState(() => 
        {
                sceneLoader.LoadScene("scene1");
        }));
        AddState(new TriggerState("holdforever"));
    }

    private IEnumerator SwitchLanguage()
    {
        yield return new WaitForSeconds(2f);
        //UpdateLanguagePref();
    }
}
