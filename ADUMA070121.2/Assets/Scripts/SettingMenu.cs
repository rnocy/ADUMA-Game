using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingMenu : MonoBehaviour
{
    public void OpenSetting()
    {
        SceneManager.LoadScene("SettingMenu");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
