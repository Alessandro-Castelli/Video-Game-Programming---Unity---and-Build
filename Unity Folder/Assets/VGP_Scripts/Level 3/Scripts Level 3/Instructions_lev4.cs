using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction_lev4: MonoBehaviour
{
    public GameObject[] objects;
    private int currentIndex = 0;
    private bool triggerOn = false;

    private void Start()
    {
        // Disattiva tutti gli oggetti all'inizio
        DeactivateAllObjects();
    }

    private void Update()
    {
        if (triggerOn)
        {

            if (currentIndex == 0)
            {
                ActivateObject(0);
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                // Disattiva l'oggetto corrente
                DeactivateObject(currentIndex);

                // Incrementa l'indice
                currentIndex = (currentIndex + 1) % objects.Length;

                if (currentIndex >= objects.Length)
                {
                    foreach (GameObject obj in objects)
                    {
                        obj.SetActive(false);
                    }

                    //Destroy(gameObject);
                }

                if (currentIndex < objects.Length)
                {
                    // Attiva il nuovo oggetto
                    ActivateObject(currentIndex);
                }


            }


        }
    }

    private void ActivateObject(int index)
    {
        objects[index].SetActive(true);
    }

    private void DeactivateObject(int index)
    {
        objects[index].SetActive(false);
    }

    private void DeactivateAllObjects()
    {
        foreach (GameObject obj in objects)
        {
            obj.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerOn = true;
    }

    private void OnTriggerExit(Collider other)
    {
        triggerOn = false;
        foreach (GameObject obj in objects)
        {
            obj.SetActive(false);
        }

        //Destroy(gameObject);
    }
    //
}
