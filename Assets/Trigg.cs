using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigg : MonoBehaviour
{
    public Canvas CanvasField;
    private bool AmIIn = false;
    void OnTriggerEnter(Collider other)
    {
        AmIIn = true;
    }
    void OnTriggerExit(Collider other)
    {
        AmIIn = false;
    }
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.E)) && (AmIIn == true))
        {
            CanvasField.enabled = !CanvasField.enabled;
        }
        if (AmIIn == false)
        {
            CanvasField.enabled = false;
        }
    }
}
