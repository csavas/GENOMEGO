using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JTTest : MonoBehaviour
{
    public void ButtonTrigger()
    {
        SceneManager.LoadScene("test", LoadSceneMode.Single);
    }
}
