using UnityEngine;

public class RandomEnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _template;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private int _count;
    [SerializeField] private Transform _target;

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
                Enemy newEnemy = Instantiate(_template, _spawnPoints[randomSpawnPoint].position, Quaternion.identity);

                newEnemy.SetTarget(_target);

                _count--;
                _spawnRunningTime = _spawnInterval;
            }
            else
            {
                _spawnRunningTime -= Time.deltaTime;
            }
        }
    }
}
