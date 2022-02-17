using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Control : MonoBehaviour
{

    public InputField In;
    public Text score;


    private void Update()
    {
        score.text = "Score :" + PlayerPrefs.GetString("name") + " " + PlayerPrefs.GetInt("score");
    }

    public void playy()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetString("name", In.text);
    }

    public void quit()
    {
        Application.Quit();
    }
}