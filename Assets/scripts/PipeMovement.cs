using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    
        [SerializeField] private float pipeSpeed = 3f;
    private void Start()
    {
        Destroy(gameObject, 10f);
    }
    private void Update()
        {
            transform.position += Vector3.left * pipeSpeed * Time.deltaTime;
        }
    
    
}
