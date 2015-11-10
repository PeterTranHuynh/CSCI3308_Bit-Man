using UnityEngine;
using System.Collections;
using System.Collections.Generic;

 public class MainMenu : MonoBehaviour
 {

 	public Texture2D icon;
    
    void OnGUI () {
        if (GUI.Button (new Rect (600, 50, 150, 100), "PLAY!")) {
            LoadLevel();
        }
    }

     void LoadLevel()
     {
         Application.LoadLevel("SceneTest");
     }
 
     void ExitApplication()
     {
         ExitApplication();
     }
 }
