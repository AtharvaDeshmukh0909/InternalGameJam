using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class StartMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1); 
    }
    public void backToStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1); 
    }
    public void HelpToStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2); 
    }
    public void help()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2); 
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-3); 
    }
    public void Quit()
    {
        Application.Quit(); 
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
