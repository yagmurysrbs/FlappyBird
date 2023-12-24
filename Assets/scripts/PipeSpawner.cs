using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipesPrefab;
    [SerializeField] private float pipeSpawnTime = 1.5f;
    [SerializeField] private float height = 0.5f;
    private void Start()
    {
        StartCoroutine(SpawnPipe());
    }
    
    private IEnumerator SpawnPipe()
    {
        while (true)
        {
            Instantiate(pipesPrefab, new Vector3(3f, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(pipeSpawnTime);
        }
    }

}
