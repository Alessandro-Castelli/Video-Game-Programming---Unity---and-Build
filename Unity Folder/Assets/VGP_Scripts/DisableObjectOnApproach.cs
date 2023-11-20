using UnityEngine;


public class DisableObjectOnApproach : MonoBehaviour
{
    public GameObject objectToDisable; // L'oggetto da disattivare
    public float activationDistance = 3f; // La distanza di attivazione dell'oggetto
    public GameObject vignetta;
    public Transform playerTransform;
    void Update()
    {
        // Calcola la distanza tra l'oggetto e il giocatore
        float distance = Vector3.Distance(transform.position, playerTransform.transform.position);

        if (distance <= activationDistance)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                // Verifica lo stato attuale dell'oggetto
                bool isActive = objectToDisable.activeSelf;

                // Inverti lo stato attuale dell'oggetto
                objectToDisable.SetActive(!isActive);
            }
        }

        if (distance > activationDistance)
        {
            vignetta.SetActive(false);
        }
        else
        {
            vignetta.SetActive(true);
        }
    }
}
