using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueGame : MonoBehaviour
{
    private int sceneContinue;

    public void ContinueScene()
    {
        sceneContinue = PlayerPrefs.GetInt("SavedScene");

        if (sceneContinue != 0)
            SceneManager.LoadScene(sceneContinue);
        else
            return;
    }


    
}
