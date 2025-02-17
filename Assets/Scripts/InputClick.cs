using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputClick : MonoBehaviour
{
    public LogicGate gate; 
    public string inputName;
   
    private void OnMouseDown()
    {
        gate.ToggleInput(inputName);
    }
}
