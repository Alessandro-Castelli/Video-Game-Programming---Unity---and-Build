using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionCompleted : MonoBehaviour
{


    public GameObject vignetta;
    public GameObject Object;
    public float thresholdDistance = 5f;
    private Transform objectPosition;
    public Transform playerTransform;
    private bool isActive;
    public Punteggio scoreManager;
    private bool punteggioAggiutnto;

    // Start is called before the first frame update
    void Start()
    {
        objectPosition = GetComponent<Transform>();
        punteggioAggiutnto = true;
    }

    // Update is called once per frame
    void Update()
    {

        isActive = Object.activeSelf;
        float distance = Vector3.Distance(objectPosition.transform.position, playerTransform.transform.position);
        
        if (distance < thresholdDistance &&  !isActive)
        {
            vignetta.SetActive(true);
            if (punteggioAggiutnto)
            {
                scoreManager.IncreaseScore(10);
                punteggioAggiutnto = false;
            }
        }
        else
        {
            vignetta.SetActive(false);
        }

    }
   
}
