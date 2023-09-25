using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logic : MonoBehaviour
{   public TextMeshProUGUI logicText;
    int score=0;
    public AudioSource backgroundMusic;
    int sumscore = 0;
    public GameObject sceneLoad;
    public AudioSource scoreSound;
    public void addScore()
    {
        score += 1;
        if (score == 12)
        {
            sumscore += 1;
            logicText.text = sumscore.ToString();
            score = 0; scoreSound.Play();
        }

    }
    public void restart()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
         backgroundMusic.Play(); 
    }
    public void gameOver()
    {
        sceneLoad.SetActive(true);
        backgroundMusic.Stop();
        Time.timeScale = 0;
    }
}
