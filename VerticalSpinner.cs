using UnityEngine;

public class VerticalSpinner : MonoBehaviour
{
    [SerializeField] float rotationspeed;

    void Update()
    {
        transform.Rotate(0, 0, rotationspeed);
    }

}
