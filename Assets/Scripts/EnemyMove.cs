using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Animator _animator;
    private void Update()
    {
        _animator = GetComponent<Animator>();
        _animator.SetFloat("Speed", 1);
        transform.Translate(2 * Time.deltaTime, 0, 0);
    }
}
