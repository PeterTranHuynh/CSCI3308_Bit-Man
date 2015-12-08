/** 
 *
 * @file LoadOnClick.cs
 *
 * @brief Class designed to change scenes within the Unity project.
 *
 * @author Peter Huynh 
 * @author Cary Sullivan
 *
 * @bug None
 * 
 */

using UnityEngine;
using System.Collections;

public class LoadOnClick : MonoBehaviour {

    public GameObject loadingImage;
 
	/** 
	 * @brief Main Function used to change scenes
	 * @param String level for the scene name
	 * @return Should not return.
	 */
	public void LoadScene(string level)
    {
        if(level == "Quit")
		{
			Application.Quit();
		}
		Application.LoadLevel(level);
    }
}