using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void Update()
    {
        Move();
    }

    public void SetDirecton(Vector3 direction)
    {
        transform.right = direction;
    }

    private void Move()
    {
        transform.Translate(Vector3.right * Time.deltaTime);
    }
}
