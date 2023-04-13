using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToMain : MonoBehaviour
{
    public void Menufunc()
    {
        Application.LoadLevel(0);
        GameControlScript.instance.gameOver = false;
        GameControlScript.instance.health = 3;
        GameControlScript.instance.score = 0;
    }
}
