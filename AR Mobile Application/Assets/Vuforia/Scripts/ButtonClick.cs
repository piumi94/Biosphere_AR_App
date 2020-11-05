using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    int index;

    //Use for Initialization
    public void Start()
    {
        index = SceneManager.GetActiveScene().buildIndex;
    }
	
	//Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

	//Navigating to the relevant scene
    public void changeScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

}
