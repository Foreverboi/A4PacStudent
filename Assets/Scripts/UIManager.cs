using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //public RectTransform loadingScreen;



    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;

        //loadingScreen.sizeDelta = new Vector2(Screen.width, Screen.height);

        //HideLoadingScreen();
    }

    void Update()
    {

    }

    private void LateUpdate()
    {

    }

    public void LoadFirstLevel()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadSceneAsync(1);
    }

    public void LoadStartScene()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadSceneAsync(0);
    }
    public void QuitGame()
    {
        Debug.Log("Quit is clicked");
        LoadStartScene();
#if UNITY_EDITOR
        //UnityEditor.EditorApplication.isPlaying = false;
#endif
#if UNITY_STANDALONE
        //Application.Quit();
#endif
    }


    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex == 1)
        {
            GameObject.FindWithTag("Exit Button").GetComponent<Button>().onClick.AddListener(QuitGame);


            //Invoke("HideLoadingScreen", 1.0f);
        }
    }
    /*
    private void HideLoadingScreen()
    {
        StartCoroutine(LerpLoadingScreen(new Vector2(0.0f, -Screen.height), 0.2f));
    }

    private void ShowLoadingScreen()
    {
        StartCoroutine(LerpLoadingScreen(new Vector2(0.0f, 0.0f), 0.2f));
    }

    public void StartButtonPressed()
    {
        ShowLoadingScreen();
        Invoke("LoadFirstLevel", 1.0f);
    }
    */

    public void StartButtonPressed()
    {
        Invoke("LoadFirstLevel", 1.0f);
    }
    
}
