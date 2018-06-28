using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dont_destroy_on_load : MonoBehaviour {

	
	void Start () {
        DontDestroyOnLoad(this.gameObject);
    }
	
}
