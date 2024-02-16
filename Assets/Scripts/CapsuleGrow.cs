using UnityEngine;

public class CapsuleGrow : MonoBehaviour
{
    [SerializeField] private float _growthSpeed;

    private void Update()
    {
        Grow();
    }

    private void Grow()
    {
        Vector3 currentSize = transform.localScale;

        currentSize += new Vector3(_growthSpeed, _growthSpeed, _growthSpeed) * Time.deltaTime;

        transform.localScale = currentSize;
    }
}