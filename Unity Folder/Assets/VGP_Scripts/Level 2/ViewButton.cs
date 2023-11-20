using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewButton : MonoBehaviour
{
    public GameObject button;
    public Transform player;
    private float approachDistance = 5f;


    // Start is called before the first frame update
    void Start()
    {
        button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);

        if (distance < approachDistance)
        {
            button.SetActive(true);
        }
        else
        { 
            button.SetActive(false);
        }

    }
}
