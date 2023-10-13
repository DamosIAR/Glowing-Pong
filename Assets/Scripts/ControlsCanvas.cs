using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsCanvas : MonoBehaviour
{
    public GameObject ControlCanvas;
    // Start is called before the first frame update
    void Start()
    {
        ControlCanvas.SetActive(false);
    }

    public void ControlsOn()
    {
        ControlCanvas.SetActive(true);
    }

    public void ControlsOff()
    {
        ControlCanvas.SetActive(false );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
