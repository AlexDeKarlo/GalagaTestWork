using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerSystem : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;
    [SerializeField]
    private List<Transform> spawnPoints = new List<Transform>();
    private int count;

    

    public void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(GameSettingsSystem.Instance.SpawnCooldonwRange.GetRandomFloatInRange());
            Instantiate(enemy, spawnPoints[Random.Range(0, spawnPoints.Count)].position, Quaternion.identity);
        }
    }
}
