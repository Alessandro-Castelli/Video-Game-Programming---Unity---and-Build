using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCar : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            // Distruggi l'oggetto con cui è avvenuta l'interazione
            Destroy(other.gameObject);
        }
    }
}
