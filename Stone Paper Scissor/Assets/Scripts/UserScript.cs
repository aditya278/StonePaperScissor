using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserScript : MonoBehaviour {

    public int choice = 0;
    public bool userChose = false;

    public void Rock()
    {
        if (!userChose)
        {
            choice = 1;
            userChose = true;
            Debug.Log("Rock");
        }
    }

    public void Paper()
    {
        if (!userChose)
        {
            choice = 2;
            userChose = true;
            Debug.Log("Paper");
        }
    }

    public void Scissor()
    {
        if (!userChose)
        {
            choice = 3;
            userChose = true;
            Debug.Log("Scissor");
        }
    }
}
