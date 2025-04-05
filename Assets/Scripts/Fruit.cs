using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public int index = 0;
    Gamemanager gamemanager;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains(gameObject.name))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            
            // spawn a bigger fruit
        }
    }
}
