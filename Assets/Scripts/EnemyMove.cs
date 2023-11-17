using UnityEngine;

[RequireComponent(typeof(Animator))]
public class EnemyMove : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _animator.SetFloat("Speed", 1);
        transform.Translate(2 * Time.deltaTime, 0, 0);
    }
}
