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

    void Start()
    {
        inputField = GetComponent<TMP_InputField>();
    }
    public void SwitchToMain()
    {
        SceneManager.LoadScene(1);
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
