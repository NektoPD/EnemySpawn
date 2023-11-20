using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform _target;
    private float _moveSpeed = 3;

    private void Update()
    {
        MoveToTarget();
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }

    private void MoveToTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _moveSpeed * Time.deltaTime);
    }
}
