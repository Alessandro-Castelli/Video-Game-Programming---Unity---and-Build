using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{ 
public float fadeSpeed = 1f;
public RawImage image;

    void Start()
    {
        // Avvia la dissolvenza nera
        StartCoroutine(FadeOut());
    }


    IEnumerator FadeOut()
    {
        // Gradualmente diminuisce l'alpha dell'immagine nera fino a 0
        while (image.color.a > 0)
        {
            Color newColor = image.color;
            newColor.a -= fadeSpeed * Time.deltaTime;
            image.color = newColor;
            yield return null;
        }
    }

}
