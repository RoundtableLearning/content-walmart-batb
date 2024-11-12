using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTL_UI_SetGlobalVariables : MonoBehaviour
{
    public RTL_UI_GlobalVariables.TargetCompany _TargetCompany = new RTL_UI_GlobalVariables.TargetCompany();


    private void Awake()
    {
        RTL_UI_GlobalVariables._TargetCompany = _TargetCompany;
    }
}
