using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpToStickers : MonoBehaviour
{
    public void buttonTrigger()
    {
        SceneManager.LoadScene("stickers", LoadSceneMode.Single);
    }
}
