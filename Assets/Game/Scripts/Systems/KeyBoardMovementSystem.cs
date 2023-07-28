using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardMovementSystem : MonoBehaviour
{
    [SerializeField]
    private Area movementArea;
    [SerializeField]
    private Transform movementObject;
    [SerializeField]
    private float speed;

    public void Start()
    {
        speed = GameSettingsSystem.Instance.PlayerSpeed;
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.W) && movementObject.position.y < movementArea.maxY)
            movementObject.position = Vector3.MoveTowards(movementObject.position, new Vector3(movementObject.position.x, movementObject.position.y + 1), speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S) && movementObject.position.y > movementArea.minY)
            movementObject.position = Vector3.MoveTowards(movementObject.position, new Vector3(movementObject.position.x, movementObject.position.y - 1), speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D) && movementObject.position.x < movementArea.maxX)
            movementObject.position = Vector3.MoveTowards(movementObject.position, new Vector3(movementObject.position.x + 1, movementObject.position.y), speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A) && movementObject.position.x > movementArea.minX)
            movementObject.position = Vector3.MoveTowards(movementObject.position, new Vector3(movementObject.position.x - 1, movementObject.position.y), speed * Time.deltaTime);
    }

}


[System.Serializable]
public class Area
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
}