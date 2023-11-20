using UnityEngine;
//è necessario passare dal giorno alla notte e per farlo cambio la luce emessa da bianca a nessuna in un periodo x di tempo
public class LoopLight : MonoBehaviour
{
    public Light targetLight;                   // Riferimento alla luce da modificare
    public Color targetColor;                   // Colore finale della luce
    public float colorChangeDuration = 2f;       // Durata del cambio di colore
    public float delayBetweenChanges = 1f;       // Ritardo tra i cambi di colore

    private Color initialColor;                 // Colore iniziale della luce
    private float timer;
    private bool isChangingColor;

    private void Start()
    {
        initialColor = targetLight.color;
        timer = 0f;
        isChangingColor = false;

        // Avvia il cambio di colore iniziale dopo un ritardo
        Invoke("StartColorChange", delayBetweenChanges);
    }

    private void Update()
    {
        if (isChangingColor)
        {
            timer += Time.deltaTime;

            // Calcola il progresso del cambio di colore
            float progress = timer / colorChangeDuration;
            targetLight.color = Color.Lerp(initialColor, targetColor, progress);

            if (timer >= colorChangeDuration)
            {
                // Inverti i colori per il prossimo cambio di colore
                Color temp = targetColor;
                targetColor = initialColor;
                initialColor = temp;

                // Reset del timer
                timer = 0f;

                // Ritarda il prossimo cambio di colore
                Invoke("StartColorChange", delayBetweenChanges);
            }
        }
    }

    private void StartColorChange()
    {
        isChangingColor = true;
    }
}
