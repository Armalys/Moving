using UnityEngine;

public class Changer : MonoBehaviour
{
    [SerializeField] private float _growthSpeed;
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _rotateSpeed;

    private void Update()
    {
        Grow();
        Rotate();
        Translate();
    }

    private void Grow()
    {
        Vector3 currentSize = transform.localScale;

        currentSize += new Vector3(_growthSpeed, _growthSpeed, _growthSpeed) * Time.deltaTime;

        transform.localScale = currentSize;
    }

    private void Rotate()
    {
        transform.RotateAround(transform.position, Vector3.up, _rotateSpeed);
    }

    private void Translate()
    {
        transform.Translate(Vector3.forward * _movementSpeed * Time.deltaTime);
    }
}