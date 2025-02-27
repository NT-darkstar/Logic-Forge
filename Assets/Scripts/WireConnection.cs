using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireConnection : MonoBehaviour
{
    private static WireConnection firstSelected = null;
    public Transform wireConnectionPoint;
    public GameObject wirePrefab; // Assign your wire prefab in the Inspector

    void OnMouseDown()
    {
        if (firstSelected == null)
        {
            firstSelected = this;
        }
        else if (firstSelected != this)
        {
            CreateWire(firstSelected, this);
            firstSelected = null; // Reset for the next connection
        }
    }

    void CreateWire(WireConnection obj1, WireConnection obj2)
    {
        if (wirePrefab == null) return;

    GameObject wireInstance = Instantiate(wirePrefab);
    LineRenderer lineRenderer = wireInstance.GetComponent<LineRenderer>();

    if (lineRenderer != null)
    {
        lineRenderer.positionCount = 2;

        // If the child connection point is assigned, use its position
        Vector3 pos1 = obj1.wireConnectionPoint ? obj1.wireConnectionPoint.position : obj1.transform.position;
        Vector3 pos2 = obj2.wireConnectionPoint ? obj2.wireConnectionPoint.position : obj2.transform.position;

        lineRenderer.SetPosition(0, pos1);
        lineRenderer.SetPosition(1, pos2);
    }
    }
}
