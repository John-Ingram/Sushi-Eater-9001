using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour {
    public GameObject particles;
    public float lifeAfterHit = 0.5f;

    private Rigidbody rigidbody2d ;
    void OnCollisionEnter2D (Collision2D collided)
    {
        particles.SetActive(true);
        Destroy(GetComponent<Rigidbody2D>());
        StartCoroutine(Death());
    }

    IEnumerator Death()
    {

        yield return new WaitForSeconds(lifeAfterHit);
        Destroy(gameObject);
    }
   
}
