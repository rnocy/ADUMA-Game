using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_back : MonoBehaviour
{
    private int currentScene;
    public void BackMenu()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentScene);
        SceneManager.LoadScene("MainMenu");
    }

    
}
