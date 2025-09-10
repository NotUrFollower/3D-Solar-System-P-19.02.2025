using System;
using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(Camera))]
public class CameraZoom : MonoBehaviour
{
    public List<Transform> planets;
    public Vector3 offset = new Vector3(0, 50, -100);
    public float smoothTime = 0.3f;
    public float zoomSpeed = 10f;
    public float minFOV = 20f;
    public float maxFOV = 100f;

    private Camera cam;
    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    private void LateUpdate()
    {
        if (planets == null || planets.Count == 0) return;
        Vector3 center = GetCenter();
        Vector3 targetPos = center + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
        transform.LookAt(center);
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0)
        {
            cam.fieldOfView = Math.Clamp(cam.fieldOfView - scroll * zoomSpeed, minFOV, maxFOV);
            
        }
    }

    Vector3 GetCenter()
    {
        if (planets.Count == 1)
            return planets[0].position;
        var bounds = new Bounds(planets[0].position, Vector3.zero);
        for (int i=1; i<planets.Count;i++)
            bounds.Encapsulate(planets[i].position);

        return bounds.center;
    }
}
