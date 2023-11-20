using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f; // Velocità di movimento della macchina

    private void Update()
    {
        // Muovi la macchina in avanti lungo l'asse Z
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
