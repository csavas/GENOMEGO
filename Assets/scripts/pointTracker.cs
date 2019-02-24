using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointTracker : MonoBehaviour
{
    public int points;

    public void increasePoints()
    {
        points = points + 10;
    }
}
