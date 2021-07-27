using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public float autoLoadLevelTimer;

    private void Start()
    {
        Invoke("LoadNextLevel", autoLoadLevelTimer);
    }
    [System.Obsolete]
    public void LoadLevel(string name)
    {
        Application.LoadLevel(name);
    }

    public void Quit()
    {
        Application.Quit();
    }

    [System.Obsolete]
    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}
