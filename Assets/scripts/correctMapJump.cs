using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class correctMapJump : MonoBehaviour
{
    public void buttonTrigger()
    {
        
        SceneManager.LoadScene("map", LoadSceneMode.Single);
    }
}
