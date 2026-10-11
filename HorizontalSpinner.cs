using UnityEngine;

public class HorizontalSpinner : MonoBehaviour
{
    [SerializeField] float rotationspeed;

    void Update()
    {
        transform.Rotate(0, rotationspeed, 0);
    }
}
