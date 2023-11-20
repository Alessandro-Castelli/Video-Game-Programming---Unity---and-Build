using UnityEngine;

public class AddPointsFountain : MonoBehaviour
{
    public float thresholdDistance = 5f;
    public Transform player;
    public Punteggio scoreManager;
    public GameObject water;
    public GameObject vignetta;
    private bool punteggioAggiunto;
    private Transform objectPosition;

    // Start is called before the first frame update
    void Start()
    {
        vignetta.SetActive(false);
        punteggioAggiunto = false;
        objectPosition = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(objectPosition.transform.position, player.transform.position);
        

        if (distance < thresholdDistance)
        {
            

            if (Input.GetKeyDown(KeyCode.E))
            {
                vignetta.SetActive(false);
                scoreManager.IncreaseScore(10);
                water.SetActive(false);
                punteggioAggiunto=true;

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!punteggioAggiunto) 
        {
            vignetta.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        vignetta.SetActive(false);
    }

}
