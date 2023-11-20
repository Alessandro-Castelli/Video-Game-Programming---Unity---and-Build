using UnityEngine;
using UnityEngine.UIElements;

//Serve per far ruotare i cubi tutorial
public class ObjectRotator : MonoBehaviour
{
    public float rotationSpeed = 10f; // Velocità di rotazione dell'oggetto

    void Update()
    {
        // Ruota l'oggetto attorno all'asse Y
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        // Ruota l'oggetto solo attorno all'asse X
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}