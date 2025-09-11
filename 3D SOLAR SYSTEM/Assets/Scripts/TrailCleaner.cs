using UnityEngine;

[RequireComponent(typeof(TrailRenderer))]
public class TrailCleaner : MonoBehaviour
{
    void Start()
    {
        // clean trail
        TrailRenderer trail = GetComponent<TrailRenderer>();
        if (trail != null)
        {
            trail.Clear();
        }
    }
}
