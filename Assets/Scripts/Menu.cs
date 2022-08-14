using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    bool LoadNewLevel;

    public void TurnGameObjectOff(GameObject go)
    {
        go.SetActive(false);
    }
    public void TurnGameObjectOn(GameObject go)
    {
        go.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void LoadLevel(string levelName)
    {
        if(!LoadNewLevel)
        {
            LoadNewLevel = true;
            SceneManager.LoadScene(levelName);
        }
        
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
