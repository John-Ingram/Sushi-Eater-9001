using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sushi_Behavior : MonoBehaviour {
    public Sprite failSushi;
    public bool canBeDamaged = true;
    public Check_For_Completion check_For_Completion;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (canBeDamaged)
        {
            if (collision.gameObject.tag == "Chopstick")
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = failSushi;
                check_For_Completion.Sushi_hurt();
            }
        }
    }
}
