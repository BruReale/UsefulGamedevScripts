using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGameEscaperoom : MonoBehaviour
{
    public float timer;
    public float timerUntilRestart;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
        }

        if (timer >= timerUntilRestart)
        {
            SceneManager.LoadScene(0);
        }

    }
}
