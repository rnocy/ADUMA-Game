﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wining : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GameOver);
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Lose1")
    }
}
