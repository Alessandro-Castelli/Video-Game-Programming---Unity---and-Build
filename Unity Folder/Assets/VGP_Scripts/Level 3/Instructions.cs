using UnityEngine;

public class Instructions : MonoBehaviour
{
    public GameObject[] objects;
    private int currentIndex = 0;
    private bool triggerOn=false;

    private void Start()
    {
        // Disattiva tutti gli oggetti all'inizio
        DeactivateAllObjects();
    }

    private void Update()
    {
        Debug.Log(keyBathroom.bathKeyTaken);
       if (triggerOn && !keyBathroom.bathKeyTaken)
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
                currentIndex = (currentIndex + 1) %objects.Length;

                if (currentIndex >= objects.Length)
                {
                    foreach (GameObject obj in objects)
                    {
                        obj.SetActive(false);
                    }

                    
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
        currentIndex = 0;
        
    }
}
