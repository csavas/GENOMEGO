using UnityEngine;
using System.Collections;

public class webCamScript : MonoBehaviour
{

    public GameObject webCameraPlane;
    void Start()
    {

        WebCamTexture webCameraTexture = new WebCamTexture();
        webCameraPlane.GetComponent<MeshRenderer>().material.mainTexture = webCameraTexture;
        webCameraTexture.Play();

    }

    void Update()
    {


    }
}
