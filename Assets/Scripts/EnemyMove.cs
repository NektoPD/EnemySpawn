using UnityEngine;

[RequireComponent(typeof(Animator))]
public class EnemyMove : MonoBehaviour
{
    private Animator _animator;
    private const string ConditionName = "Speed";
    private float _enemySpeed = 1;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _animator.SetFloat(ConditionName, _enemySpeed);
    }
}
