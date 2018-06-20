using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path_follower : MonoBehaviour {
    public GameObject[] waypoints;
    public float speed = 1;
    public bool go = false;
    public float minDist;
    public bool showWaypoints = false;


    private int index = 0;


	// Use this for initialization
	void Start () {
        foreach (GameObject thing in waypoints)
        {
            thing.SetActive(showWaypoints);
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (index < waypoints.Length)
        {
            float dist = Vector2.Distance(gameObject.transform.position, waypoints[index].transform.position);

            if (go)
            {
                if (dist > minDist)
                {
                    Move();
                }
                else
                {
                   
                        index++;
                }
            }
        }
        else
        {
            index = 0;
        }
	}

    public void Move()
    {
        Vector2 target = waypoints[index].transform.position;
        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, target, (speed/1000));
    }
}
