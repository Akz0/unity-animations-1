using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public AnimationCurve directionCurve;
    public float Scale = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * directionCurve.Evaluate(Mathf.Repeat(Time.time, 1.0f)) * Time.deltaTime * Scale;
    }
}
