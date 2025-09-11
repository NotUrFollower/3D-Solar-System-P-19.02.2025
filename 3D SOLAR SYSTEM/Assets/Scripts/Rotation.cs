using UnityEngine;

public class Rotation : MonoBehaviour
{
    [Range(-100, 100)] public float RotationSpeed = 10;

    public Vector3 RotationAxis = new Vector3(0, 1, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RotationAxis = Random.insideUnitSphere;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotationAxis *(RotationSpeed * Time.deltaTime));
    }
}
