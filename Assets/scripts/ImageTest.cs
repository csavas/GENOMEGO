using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageTest : MonoBehaviour
{
    public Image myimage;
    // Start is called before the first frame update
    void Start()
    {
        myimage = GetComponent<Image>();
        myimage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
