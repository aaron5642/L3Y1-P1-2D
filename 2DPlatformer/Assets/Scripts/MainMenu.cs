using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
       public Canvas main;
       public Canvas options; 
    // Start is called before the first frame update
    void Start()
    {
      main.enabled = true;
      options.enabled = false;
    }

    // Update is called once per frame
    public void onPlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void onOptions()
    {
        main.enabled = false;
        options.enabled = true;
    }
    public void onExit()
    {
    Application.Quit();
            
        
    }
    public void OnBackToMain()
    {
       main.enabled = true;
       options.enabled = false;
    }
}



