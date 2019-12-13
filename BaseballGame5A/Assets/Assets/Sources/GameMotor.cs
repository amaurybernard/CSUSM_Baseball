using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMotor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void switchToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void quit()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
