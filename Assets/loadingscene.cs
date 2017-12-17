using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadingscene : MonoBehaviour {

	public void change(string Scenes)
    {
        SceneManager.LoadScene(Scenes);
    
		
	}
}
