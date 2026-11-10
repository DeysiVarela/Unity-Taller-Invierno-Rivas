using UnityEngine;

public class SirenRotation : MonoBehaviour
{
    [Min(0f)]
    public float rotationSpeed = 180f;

    private void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.Self);
    }
}
