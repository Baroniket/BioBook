using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadBioBook : MonoBehaviour
{
    public Text progressText;
    // Start is called before the first frame update
    void Start()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("BioBookScene");
        while(!operation.isDone)
       {
           float progress = Mathf.Clamp01(operation.progress/.9f);
           progressText.text = progress * 100f + "%";
       }
    }
}
