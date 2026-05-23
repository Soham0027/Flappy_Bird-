using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;

    void Start()
    {
        InvokeRepeating("SpawnPipe", 1f, 1f);
    }

    void SpawnPipe()
    {
        Instantiate(pipePrefab, transform.position, Quaternion.identity);
    }
}