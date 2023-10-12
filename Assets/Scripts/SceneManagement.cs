using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public GameObject CanvasControl;
    void Start(){
        CanvasControl.SetActive(false);
    }

    public void ChangeScene (string sceneName){
        SceneManager.LoadScene(sceneName);
    }

    public void ControlsOff()
    {
        CanvasControl.SetActive(false );
    }

    public void ControlsOn()
    {
        CanvasControl.SetActive(true);
    }

    public void QuitApp(){
        Application.Quit();
    }
}
