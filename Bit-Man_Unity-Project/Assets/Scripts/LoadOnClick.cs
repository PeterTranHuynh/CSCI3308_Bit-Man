using UnityEngine;
using System.Collections;

public class LoadOnClick : MonoBehaviour {

    public GameObject loadingImage;

	public void LoadScene(string level)
    {
        //loadingImage.SetActive(true); // UNNEEDED
        if(level == "Quit")
		{
			Application.Quit();
		}
		Application.LoadLevel(level);
    }
}