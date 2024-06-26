using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private string sceneName = "MainScene";
    [SerializeField] private GameObject continueButton;
    [SerializeField] private UIFadeScreen fadeScreen; 

    private void Start()
    {
        if (SaveManager.instance.HasSavedData() == false)
        {
            continueButton.SetActive(false);
        }
    }
    public void ContinueGame()
    {
        //StartCoroutine(LoadSceneWithFadeEffect(1.5f)); 
        SceneManager.LoadScene(sceneName);
    }

    public void NewGame()
    {
        SaveManager.instance.DeleteSavedData();
        //StartCoroutine(LoadSceneWithFadeEffect(1.5f));
        SceneManager.LoadScene(sceneName);
    }

    public void ExitGame()
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }

    //IEnumerator LoadSceneWithFadeEffect(float _delay)
    //{
    //    fadeScreen.FadeOut();

    //    yield return new WaitForSeconds(_delay);

    //    SceneManager.LoadScene(sceneName);
    //}
}
