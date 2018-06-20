using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour {
    public GameObject particles;
    public float lifeAfterHit = 0.5f;
	
    void OnCollisionEnter2D (Collision2D collided)
    {
        particles.SetActive(true);
        StartCoroutine(Death());
    }

    IEnumerator Death()
    {

        yield return new WaitForSeconds(lifeAfterHit);
        Destroy(gameObject);
    }
   
}
