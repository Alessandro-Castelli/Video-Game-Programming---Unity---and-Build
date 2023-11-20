using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCar : MonoBehaviour
{

    public GameObject objectPrefab; // Prefab dell'oggetto da creare
    public Color[] colors; // Array di colori disponibili

    private float timer = 0f;
    private float spawnInterval = 5f; // Intervallo di tempo tra ogni creazione

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            CreateObject();
            timer = 0f;
        }
    }

    private void CreateObject()
    {
        // Crea un'istanza dell'oggetto
        GameObject newObject = Instantiate(objectPrefab, transform.position, Quaternion.identity);

        // Assegna un colore casuale all'oggetto
        Renderer objectRenderer = newObject.GetComponent<Renderer>();
        objectRenderer.material.color = colors[Random.Range(0, colors.Length)];
    }
}

