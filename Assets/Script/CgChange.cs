using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;
public class CgChange : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        
    }
   public  void GoToGameScene()
    {
        SceneManager.LoadScene(13);
    }
    public void goout()
    {
        Application.Quit();
        EditorApplication.isPlaying = false;
    }

}
