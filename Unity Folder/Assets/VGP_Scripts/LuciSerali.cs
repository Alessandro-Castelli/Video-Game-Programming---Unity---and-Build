using UnityEngine;

public class LuciSerali : MonoBehaviour
{
    private float timer;
    public float eventInterval = 720f;  // Intervallo di tempo in secondi tra gli eventi
    public GameObject night_light;

    private void Start()
    {
        timer = eventInterval;
    }

    private void Update()
    {
        night_light.SetActive(true);
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
     
            DoSomething();

            // Resettare il timer 
            timer = eventInterval;

            
        }
    }

    private void DoSomething()
    {
        night_light.SetActive(false);
    }
}
