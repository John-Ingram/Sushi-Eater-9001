using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path_follower : MonoBehaviour {
    public GameObject[] waypoints;
    public float speed = 1;
    public bool go = false;
    public float minDist;
    public bool showWaypoints = false;
    public int restartAt = 1;
    public int teleportFrom = 1;
    private int index;


	void Start ()
    {
        foreach (GameObject thing in waypoints)
        {
            thing.SetActive(showWaypoints);
        }
	}
	

	void Update ()
    {
        if (index < waypoints.Length)
        {
            if (index == teleportFrom)
            {
                gameObject.transform.position = waypoints[teleportFrom + 1].transform.position;
                index++;
            }
            else
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
            
        }
        else
        {
            index = restartAt;
        }
	}

    public void Move()
    {
        Vector2 target = waypoints[index].transform.position;
        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, target, (speed/1000));
    }
}
