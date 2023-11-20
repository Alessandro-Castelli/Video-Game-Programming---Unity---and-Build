using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCont : MonoBehaviour
{

    public GameObject specialIndizio;
    public float thresholdDistance = 2f;
    private Transform objectPosition;
    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        objectPosition = GetComponent<Transform>();
    }
    void Update()
    {

        float distance = Vector3.Distance(objectPosition.transform.position, playerTransform.transform.position);

        if (distance < thresholdDistance && Input.GetKeyDown(KeyCode.H))
        {
            // Verifica lo stato attuale dell'oggetto
            bool isActive = specialIndizio.activeSelf;

            // Inverti lo stato attuale dell'oggetto
            specialIndizio.SetActive(!isActive);
        }

    }
 }


