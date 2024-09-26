using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;

#if UNITY_EDITOR
using UnityEngine;
# endif
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIManager : MonoBehaviour
{
    public TMP_InputField inputField;
    private string playerName;

    void Start()
    {
        inputField = GetComponent<TMP_InputField>();
    }
    public void GameStart()
    {
        SceneManager.LoadScene(1);
        playerName = inputField.text;
    }

    public void QuitGame()
    {
        # if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        # else
            Application.Quit();
        # endif
    }
}
