using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] fruits;
    
    public TMP_Text scoreText;
    public TMP_Text watermelonText;
    
    private int count = 0;
    private int count1 = 0;
    private int score = 0;
    private int watermelon = 0;

    void Start()
    {
        score = 0;
        watermelon = 0;
        scoreText.text = score.ToString();
        watermelonText.text = watermelon.ToString();
    }
    private void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.y = 3;
        Vector3 offset = new Vector3(0, 0, 10);

        if (Input.GetMouseButtonDown(0))
        {
            SpawnNewFruit(Random.Range(0, 3), mousePos + offset);
        }
    }

    public void SpawnFruit(int index, Vector3 position)
    {
        count++;

        if (count == 2 && index + 1 < fruits.Length)
        {
            SpawnNewFruit(index + 1, position);
            count = 0;
        }
    }

    public void AddScore(int index)
    {
        count1++;

        if (count1 == 2)
        {
            score += index;
            scoreText.text = score.ToString();

            if (index == 8)
            {
                watermelon++;
                watermelonText.text = watermelon.ToString();
            }

            count1 = 0;
        }
    }

    private void SpawnNewFruit(int index, Vector3 position)
    {
        GameObject fruitObj = Instantiate(fruits[index], position, Quaternion.identity);
        Fruit fruitScript = fruitObj.GetComponent<Fruit>();
        if (fruitScript != null)
        {
            fruitScript.manager = this;
            fruitScript.index = index;
        }
    }
}
