using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashToMenu : MonoBehaviour
{
    public float autoload;
    
    void Start()
    {
        Invoke("LoadLevel",autoload);
    }

    public void LoadLevel()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Menu");
    }
}
