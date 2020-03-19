using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
   public void learn()
   {
       Debug.Log("Learn button pressed");
       SceneManager.LoadScene("LoadScreen");
   }

   public void exit()
   {
       Debug.Log("Exit button pressed");
       Application.Quit();
   }
}
