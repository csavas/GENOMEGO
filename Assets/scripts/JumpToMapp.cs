using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JumpToMapp : MonoBehaviour
{
    public void buttonTrigger()
    {
        SceneManager.LoadScene("map", LoadSceneMode.Single);
    }
}
