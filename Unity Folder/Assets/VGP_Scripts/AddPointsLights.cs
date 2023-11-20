using System;
using System.Globalization;
using TMPro;
using UnityEngine;


public class AddPointsLights : MonoBehaviour
{
    public TMP_Text clockText;  // Riferimento al componente TextMeshProUGUI dell'orologio digitale
    public Transform player;
    private Transform objectPosition;
    public GameObject vignetta;
    public GameObject vignettanobuio;
    public GameObject vignettacongratulations;
    public float thresholdDistance = 5f;
    public Punteggio scoreManager;
    public GameObject luci_notte;
    private bool punti_gia_aggiunti;
    private void Start()
    {
        vignetta.SetActive(false);
        vignettanobuio.SetActive(false);
        vignettacongratulations.SetActive(false);
        objectPosition = GetComponent<Transform>();
        punti_gia_aggiunti = false;
    }
    private void Update()
    {

        float distance = Vector3.Distance(objectPosition.transform.position, player.transform.position);
        string currentTimeString = clockText.text;

        DateTime currentTime;
        if (DateTime.TryParseExact(currentTimeString, "HH:mm", null, DateTimeStyles.None, out currentTime))
        {

            TimeSpan eveningStart = new TimeSpan(20, 0, 0);   // 8 di sera
            TimeSpan morningStart = new TimeSpan(8, 0, 0);    // 8 di mattina

            TimeSpan currentTimeOfDay = currentTime.TimeOfDay;

            
            if (currentTimeOfDay >= eveningStart || currentTimeOfDay > morningStart)
            { 
                if (Input.GetKeyDown(KeyCode.E)  && distance < thresholdDistance && !punti_gia_aggiunti)
                {
                    scoreManager.IncreaseScore(20);
                    luci_notte.SetActive(false);
                    punti_gia_aggiunti = true;
                    vignettacongratulations.SetActive(true);
                }
            }
            else 
            {
                luci_notte.SetActive(true);
                punti_gia_aggiunti = false;
                if (Input.GetKeyDown(KeyCode.E) && distance < thresholdDistance) 
                {
                    vignettanobuio.SetActive(true);
                }
            }
        }
        
        //Debug.Log(distance + " " + gameObject);
        if (distance > thresholdDistance)
        {
            vignetta.SetActive(false);
            vignettanobuio.SetActive(false);
            vignettacongratulations.SetActive(false);
            //Debug.Log(punteggioAggiunto);
        }
        else if (distance < thresholdDistance)
        {
            vignetta.SetActive(true);
        }
    }

}
