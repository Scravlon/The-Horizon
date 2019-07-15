using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttonController : MonoBehaviour {

    public GameObject settingGui;
    public GameObject leaveGui;
    public GameObject guideGui;
    public GameObject touchField;
    public GameObject muteGame;
    public Sprite muteSpr;
    public Sprite unmuteSpr;
  
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void showSetting()
    {
        settingGui.SetActive(true);
        touchField.SetActive(false);
    }

    public void hideSetting()
    {
        settingGui.SetActive(false);
        touchField.SetActive(true);
    }

    public void showLeave() {
        leaveGui.SetActive(true);
        touchField.SetActive(false);
    }
    
    public void hideLeave()
    {
        leaveGui.SetActive(false);
        touchField.SetActive(true);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void showGuide()
    {
        guideGui.SetActive(true);
        touchField.SetActive(false);
    }

    public void hideGuide()
    {
        guideGui.SetActive(false);
        touchField.SetActive(true);
    }

    public void checkMute()
    {
        if(PlayerPrefs.GetInt("mute") == 0)
        {
            AudioListener.volume = 0f;
            muteGame.GetComponent<Image>().sprite = muteSpr;
            PlayerPrefs.SetInt("mute", 1);
        } else
        {
            AudioListener.volume = 1f;
            muteGame.GetComponent<Image>().sprite = unmuteSpr;
            PlayerPrefs.SetInt("mute", 0);
        }
    }
}
