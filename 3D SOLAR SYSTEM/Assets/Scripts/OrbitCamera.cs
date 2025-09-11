using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    public Transform target;
    public float distance = 50;
    public float zoomSpeed = 10f;
    public float rotationSpeed = 200f;
    public float minDistance = 10f;
    public float maxDistance = 200f;

    private float _yaw;
    private float _pitch;
    
    // Update is called once per frame
    void LateUpdate()
    {
        if (target == null) return;
        
        if (Input.GetMouseButton(1))
        {
            _yaw += Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            _pitch -= Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
            _pitch = Mathf.Clamp(_pitch, -80f, 80f);
        }
            float scroll = Input.GetAxis("Mouse ScrollWheel");
            distance = Mathf.Clamp(distance-scroll* zoomSpeed, minDistance, maxDistance);
            
            Quaternion rotation = Quaternion.Euler(_pitch, _yaw,0);
            Vector3 offset = rotation * new Vector3(0, 0, -distance);
            transform.position = target.position+offset;
            transform.LookAt(target);
    }


    
}
