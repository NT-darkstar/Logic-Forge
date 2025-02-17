using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANDGate : MonoBehaviour
{
    public Renderer inputA;
    public Renderer inputB;  
    public Renderer output;  

    private bool isInputAActive = false;
    private bool isInputBActive = false;
    void Start()
    {
        SetColor(inputA, Color.red);
        SetColor(inputB, Color.red);
        SetColor(output, Color.red);
    }


    void Update()
    {
        bool outputState = isInputAActive && isInputBActive;
        SetColor(output, outputState ? Color.green : Color.red);
    }

    public void ToggleInput(string inputName)
    {
        // Toggle the input state when clicked
        if (inputName == "A")
        {
            isInputAActive = !isInputAActive;
            SetColor(inputA, isInputAActive ? Color.green : Color.red);
        }
        else if (inputName == "B")
        {
            isInputBActive = !isInputBActive;
            SetColor(inputB, isInputBActive ? Color.green : Color.red);
        }
    }

      private void SetColor(Renderer renderer, Color color)
    {
        if (renderer != null)
            renderer.material.color = color;
    }
}
