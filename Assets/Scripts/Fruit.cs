using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public int index = 0;
    public GameManager manager;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Fruit otherFruit = collision.gameObject.GetComponent<Fruit>();
        if (otherFruit != null && otherFruit.index == this.index)
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            
            manager.SpawnFruit(index, gameObject.transform.position);
            manager.AddScore(index+1);
        }
    }
}
