using UnityEngine;

public class MultipleBox : MonoBehaviour
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

                // Attiva il nuovo oggetto
                ActivateObject(currentIndex);
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
        currentIndex = 0;
        foreach (GameObject obj in objects)
        {
            obj.SetActive(false);
        }


    }
}
