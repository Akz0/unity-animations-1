
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float RotateSpeed = 100.0f;
    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(transform.up, RotateSpeed * Time.deltaTime);
    }
}
