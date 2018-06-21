using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Check_For_Completion : MonoBehaviour {
    public String nextScene;
    public int numberOfPlayers;
    public float waitTime = 0.5f;
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
    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(nextScene);
    }
}
