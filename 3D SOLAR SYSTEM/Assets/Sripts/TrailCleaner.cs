using UnityEngine;

[RequireComponent(typeof(TrailRenderer))]
public class TrailCleaner : MonoBehaviour
{
    void Start()
    {
        // очищаем хвост при запуске
        TrailRenderer trail = GetComponent<TrailRenderer>();
        if (trail != null)
        {
            trail.Clear();
        }
    }
}
