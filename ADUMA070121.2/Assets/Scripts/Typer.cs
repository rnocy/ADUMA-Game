using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Typer : MonoBehaviour
{

    //add a wordbank
    public Text wordOutput = null;
    private string remainingWord = string.Empty;
    private string currentWord = "muffins";
    public string[] arrStr_bank;
    public static bool boo_gameOver;
    public int int_wordCount;
    public TextMeshProUGUI winText;
    int int_correct;
    public Timer scr_time;


    private void Awake()
    {
        winText.gameObject.SetActive(false);
    }
    public void fn_init()
    {        
        SetCurrentWord();
    }
    void fn_pick()
    {

    }
    private void SetCurrentWord()
    {
        //Use wordbank here.
        //SetRemainingWord(currentWord);\
        if (int_wordCount > 0)
        {
            currentWord = arrStr_bank[Random.Range(0, arrStr_bank.Length)];
            SetRemainingWord(currentWord);
            int_wordCount -= 1;
        }
        else
        {
            Timer.boo_stop = true;
            Debug.Log("Win");
            winText.gameObject.SetActive(true);
            //wining condition
        }
        
    }

    private void SetRemainingWord(string newString)
    {
        remainingWord = newString;
        wordOutput.text = remainingWord;
    }

    void Update()
    {
        if (!boo_gameOver) CheckInput();
    }

    private void CheckInput()
    {
        if (Input.anyKeyDown)
        {
            string keysPressed = Input.inputString;
            
            if (keysPressed.Length == 1)
                EnterLetter(keysPressed);
        }
    }

    private void EnterLetter(string typedLetter)
    {
        if (IsCorrectLetter(typedLetter))
        {
            int_correct += 1;
            RemoveLetter();

            if (IsWordComplete())
                SetCurrentWord();
        }
        else int_correct -= 1;
        if (Mathf.Abs(int_correct) == 3)
        {
            scr_time.fn_time(int_correct > 0);
            ///add UI for combo announcement
        }
    }

    private bool IsCorrectLetter(string letter)
    {
        return remainingWord.IndexOf(letter) == 0;
    }

    private void RemoveLetter()
    {
        string newString = remainingWord.Remove(0, 1);
        SetRemainingWord(newString);
    }

    private bool IsWordComplete()
    {
        return remainingWord.Length == 0;
    }

}