using UnityEngine;

public class ReplyObject : MonoBehaviour
{
    public GameObject objectToReplicate;   // L'oggetto da replicare
    public int replicationCount = 10;       // Numero di replicazioni
    public Vector3 minCoordinates = new Vector3(-208f,1f,-115f);         // Coordinate minime per la posizione casuale (X, Y, Z)
    public Vector3 maxCoordinates= new Vector3(90f,1f,80f);       // Coordinate massime per la posizione casuale (X, Y, Z)

    private void Start()
    {
        ReplicateObjects();
    }

    private void ReplicateObjects()
    {
        for (int i = 0; i < replicationCount; i++)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(minCoordinates.x, maxCoordinates.x),
                Random.Range(minCoordinates.y, maxCoordinates.y),
                Random.Range(minCoordinates.z, maxCoordinates.z)
            );

            Instantiate(objectToReplicate, randomPosition, Quaternion.identity);
        }
    }
}
