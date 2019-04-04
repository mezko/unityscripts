using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void StartGame3()
    {
        SceneManager.LoadScene(2);
    }
    public void StartGame4()
    {
        SceneManager.LoadScene(3);
    }
    public void StartGame5()
    {
        SceneManager.LoadScene(4);
    }
}
