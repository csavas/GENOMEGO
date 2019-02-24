using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpToHome : MonoBehaviour
{
    public void buttonTrigger()
    {
        SceneManager.LoadScene("home", LoadSceneMode.Single);
    }
}
