using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Check_For_Completion : MonoBehaviour {
    public String nextScene;
    public int numberOfPlayers;
    public float waitTime = 0.5f;
    public TextMeshProUGUI score;
    public Throw thrower;
    public GameObject restartButton;


    private int playersFinished;


    private void Update()
    {
        if (playersFinished == numberOfPlayers)
        {
            StartCoroutine(LoadScene());
        }

    }

    public void PlayerFinished()
    {
        playersFinished++ ;
        
    }

    public void HungryAgain()
    {
        playersFinished--;
    }

    public void Sushi_hurt()
    {
        score.text = "Oh no!";
        restartButton.SetActive(true);
        Time.timeScale = 0;
        Time.fixedDeltaTime = 0.02f;
        thrower.DisableThrow();
    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(nextScene);
    }

    public void UpdateScore()
    {
        score.text = playersFinished.ToString() + " of " + numberOfPlayers.ToString() + " full";
    }

    public void DoRestart()
    {
        Scene scene = SceneManager.GetActiveScene();
        Time.timeScale = 1;
        Time.fixedDeltaTime = 0.02f;
        SceneManager.LoadScene(scene.name);
    }
}
