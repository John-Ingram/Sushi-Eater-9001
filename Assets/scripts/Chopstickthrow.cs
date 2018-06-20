using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chopstickthrow : MonoBehaviour {
    public GameObject targetObj;
    public float speed = 1;

    private bool hasCollided = false;
	// Use this for initialization
	void Start () {
      
    }
    private void OnCollisionEnter2D(Collision2D thing)
    {
        if (thing.gameObject.tag == "Sushi")
        {
            hasCollided = true;
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update () {
        if (!hasCollided)
        {
            Vector2 target = targetObj.transform.position;
            gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, target, speed / 100);
        }

    }
}
