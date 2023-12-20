using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class columnpool : MonoBehaviour
{
    private GameObject[] columns;
    private Vector2 objectPoolPosition = new Vector2(34.5f,0.4f);
    private float timeSiceLastSpawned;
    private float spawnXPosition = 10f;
    private int currentColumn = 0;

    public int columnsPoolSize = 5; 
    public GameObject columnPrefab;
    public float spawnRate = 1;
    public float columnsMin = 0.4f;
    public float columnsmmMax =34.5f;
    // Start is called before the first frame update
    void Start()
    {
        columns = new GameObject[columnsPoolSize];
        for (int i = 0; i < columnsPoolSize; i++)
        {
            columns[i]  = GameObject .Instantiate(columnPrefab, objectPoolPosition,Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSiceLastSpawned += Time.deltaTime;

        if (GamesControls.instance.gameOver == false && timeSiceLastSpawned >= spawnRate) 
        {
            timeSiceLastSpawned = 0;
            float spawnYPosition  = Random.Range (columnsMin, columnsmmMax); 
            columns[currentColumn].transform.position = new Vector2 (spawnXPosition, spawnYPosition);
            currentColumn++;
            if (currentColumn >= columnsPoolSize);
            {
                currentColumn = 0;
            }
        }
    }
}
