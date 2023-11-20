using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTrigger : MonoBehaviour
{
    public GameObject box;
    public GameObject activate;
    public Transform playerTransform;
    public float thresholdDistance = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(playerTransform.transform.position, box.transform.position);
        bool isActive = activate.activeSelf;
        if (distance < thresholdDistance && !isActive)
        {
         
            box.SetActive(!isActive);
        }
    }
}
