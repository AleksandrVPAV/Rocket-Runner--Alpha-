using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Obstacle[] _obstacles;
    [SerializeField] private SpawnPoint[] _spawnPoints;
    [SerializeField] private float spawnInterval;
    [SerializeField] private int _spawnChance;

    private float elapsedTime = 0f;
    private void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > spawnInterval)
        {
            SpawnObstacle();
            elapsedTime = 0f;
        }
    }
    
    private void SpawnObstacle()
    {
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            if (Random.Range(0, 100) < _spawnChance)
            {
                int obstacleIndex = Random.Range(0, _obstacles.Length);
                Instantiate(_obstacles[obstacleIndex], _spawnPoints[i].transform.position, Quaternion.identity);
            }
        }        
    }
}
