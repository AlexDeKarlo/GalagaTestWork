using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxController : MonoBehaviour
{
    [SerializeField] 
    private float speed;
    [SerializeField] 
    private Vector3 respawnPosition;
    [SerializeField] 
    private Vector3 targetPosition;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        if (transform.position == targetPosition) 
            transform.position = respawnPosition;
    }
}
