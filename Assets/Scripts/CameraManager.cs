using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    GameObject gameCamera;
    private void Start()
    {
        CameraSetting();
    }
    
    void CameraSetting()
    {
        gameCamera = GameObject.FindGameObjectWithTag("MainCamera");
        gameCamera.GetComponent<Camera>().clearFlags = CameraClearFlags.SolidColor;
        gameCamera.GetComponent<Camera>().backgroundColor = Color.black;
    }

}
