using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class progression : MonoBehaviour
{
    public Image img;

    public void progressStart()
    {
        StartCoroutine(progressThatBar());
    }

    //00641026
    IEnumerator progressThatBar()
    {
        if(img.fillAmount < 1)
        {
            yield return new WaitForSeconds(0.1f);
            img.fillAmount = img.fillAmount + 0.00641026f;
        }
    }
}
