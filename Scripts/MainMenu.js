using UnityEngine;
 using System.Collections;
 
 public class MainMenu : MonoBehaviour 
 {
     public void LoadLevel(int levelIndex)
     {
         Application.LoadLevel(levelIndex);
     }
 
     public void ExitApplication()
     {
         ExitApplication();
     }
}
