using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        Translate();
    }

    private void Translate()
    {
        transform.Translate(Vector3.forward * (_moveSpeed * Time.deltaTime));
    }
}