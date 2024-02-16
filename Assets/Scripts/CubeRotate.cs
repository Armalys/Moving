using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.RotateAround(transform.position, Vector3.up, _rotateSpeed);
    }
}