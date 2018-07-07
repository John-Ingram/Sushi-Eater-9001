using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour {
    public GameObject[] text;
    public GameObject[] allAtOnce;

    private int index;

	void Update () {
        if (allAtOnce[0].activeSelf)
        {
            Time.timeScale = 0;
            Time.fixedDeltaTime = 0.02f;
        }
        else
        {
            Time.timeScale = 1;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Next();
        }
    }

    //moves to the next bit of the dialog
    private void Next()
    {
        if(index - 1 <= text.Length)
        {
            text[index].SetActive(false);                   //set the text currently being displayed to inactive
            index++;
        }
        if (index < text.Length)
        {
            text[index].SetActive(true);            // if there is more text, make the next one active
        }
        else                                            // if there is no more text, get rid of the other stuff
        {
            foreach(GameObject thing in allAtOnce)
            {
                thing.SetActive(false);
            }
        }
        
    }
}
