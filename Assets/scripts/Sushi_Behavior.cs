using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sushi_Behavior : MonoBehaviour {
    public Sprite failSushi;
    public bool canBeDamaged = true;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (canBeDamaged)
        {
            if (collision.gameObject.tag == "Chopstick")
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = failSushi;
            }
        }
    }
}
