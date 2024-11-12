using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RTL.Atlas;

public class CCToggleActive : MonoBehaviour
{
    [SerializeField] private Canvas ccCanvas;
    public void ToggleCC()
    {
        ccCanvas.enabled = LanguageManager.instance.showClosedCaptioning;
    }
}
