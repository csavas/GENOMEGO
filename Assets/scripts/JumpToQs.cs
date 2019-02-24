using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpToQs : MonoBehaviour
{
    public void buttonTrigger()
    {
        SceneManager.LoadScene("question", LoadSceneMode.Single);
    }
}
