using UnityEngine;

public class RandomEnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private int _count;

    private float _spawnInterval = 2;
    private float _spawnRunningTime;
    
    private void Start()
    {
        _spawnRunningTime = _spawnInterval;
    }

    private void Update()
    {
        if (_count > 0)
        {
            if (_spawnRunningTime <= 0)
            {
                int randomSpawnPoint = Random.Range(0, _spawnPoints.Length);
                GameObject newEnemy = Instantiate(_enemy, _spawnPoints[randomSpawnPoint].position, Quaternion.identity);
                
                SetEnemyDirecton(newEnemy);

                _count--;
                _spawnRunningTime = _spawnInterval;
            }
            else
            {
                _spawnRunningTime -= Time.deltaTime;
            }
        }
    }

    private void SetEnemyDirecton(GameObject enemy)
    {
        enemy.transform.Translate(Vector2.right);
    }
}
