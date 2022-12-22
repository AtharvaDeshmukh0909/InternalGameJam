using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneSwitch : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("fpsShooter"); 
    }
    public void Help()
    {
        SceneManager.LoadScene("Rules"); 
    }
    public void HelpToStart()
    {
        SceneManager.LoadScene("StartScene"); 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
