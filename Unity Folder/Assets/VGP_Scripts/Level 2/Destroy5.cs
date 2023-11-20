using UnityEngine;

public class Destroy5 : MonoBehaviour
{
    private void Start()
    {
        Invoke("DisableSelf", 5f);
    }

    private void DisableSelf()
    {
        gameObject.SetActive(false);
    }
}
