using UnityEngine;

public class Satelite : MonoBehaviour
{
    [Range(-100, 100)] public float SateliteSpeed = 10;
    public Vector3 SateliteAxis = new Vector3(0, 1, 0);
    public Transform CenterObject;

    // Update is called once per frame
    void Update()
    {
        if (CenterObject != null)
        {
            transform.RotateAround(CenterObject.position, SateliteAxis, SateliteSpeed * Time.deltaTime);
        }
    }
}
