using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpToScoreboard : MonoBehaviour
{
    public void buttonTrigger()
    {
        SceneManager.LoadScene("scoreboard", LoadSceneMode.Single);
    }
}
