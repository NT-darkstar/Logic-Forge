using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject sphere; 
    private bool isGreen = false; 


    private void OnMouseDown()
    {
        if (sphere != null)
        {
            if (isGreen)
            {
                sphere.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                sphere.GetComponent<Renderer>().material.color = Color.green; 
            }

            isGreen = !isGreen; 
        }
    }
}
