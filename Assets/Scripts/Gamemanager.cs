using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public GameObject[] fruits;
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.y = 3;
        Vector3 offset = new Vector3(0, 0, 10);
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fruits[Random.Range(0, 3)], mousePos + offset, Quaternion.identity);
        }
    }
}
