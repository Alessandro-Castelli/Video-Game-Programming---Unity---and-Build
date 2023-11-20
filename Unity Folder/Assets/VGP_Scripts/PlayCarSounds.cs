
using UnityEngine;

//Se la macchina è accesa allora il player sente il rumore del motore se si triva entro trashholDistance
public class PlayCarSounds : MonoBehaviour
{
    public AudioSource motoreRumore;
    public Transform player;
    private Transform objectPosition;
    public float thresholdDistance = 5f;
    public GameObject fumoAttivo;
    
    private void Start()
    {
        
        objectPosition = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        bool attivo = fumoAttivo.activeSelf;
        float distance = Vector3.Distance(objectPosition.transform.position, player.transform.position);
        //Debug.Log(distance + " " + gameObject);
        if (distance < thresholdDistance && attivo)
        {
            motoreRumore.enabled = true;
        }
        else 
        {
            motoreRumore.enabled = false;
        }
    }
}
