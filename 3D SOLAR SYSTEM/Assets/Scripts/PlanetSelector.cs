using UnityEngine;

public class PlanetSelector : MonoBehaviour
{
    public OrbitCamera OrbitCamera;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.CompareTag("Planet"))
                {
                    OrbitCamera.target = hit.collider.transform;
                }
            }
        }
    }
}
