using UnityEngine;

public class SphereMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Translate();
    }

    private void Translate()
    {
        transform.Translate(Vector3.forward * (_speed * Time.deltaTime));
    }
}