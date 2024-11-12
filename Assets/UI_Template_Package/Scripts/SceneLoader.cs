using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Collections;

public class SceneLoader : MonoBehaviour
{
    public GameObject menu;
    public void LoadScene(string sceneName)
    {
        if (menu)    
            menu.SetActive(false);
        Fader.instance.dimmerObj.SetActive(true);
        Fader.instance.dimmerObj.GetComponent<Dimmer>().Fade(true, 2f);
        StartCoroutine(LoadTheScene(sceneName));
    }

    public void ExitApplication()
    {
        if (menu)
            menu.SetActive(false);
        Fader.instance.dimmerObj.SetActive(true);
        Fader.instance.dimmerObj.GetComponent<Dimmer>().Fade(true, 2f);
        StartCoroutine(ExitTheApp());
    }

    
    private IEnumerator LoadTheScene(string sceneName)
    {

        yield return new WaitForSeconds(3f);
        SceneManager.LoadSceneAsync(sceneName);
    }

    private IEnumerator ExitTheApp()
    {
        yield return new WaitForSeconds(3f);
        Application.Quit();

    }
}