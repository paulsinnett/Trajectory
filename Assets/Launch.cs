using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{
    public Rigidbody rigidbody;
    public Transform target;
    public float T = 10;

    void Reset()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        Vector3 a = transform.position;
        Vector3 b = target.position;

        float u = T / rigidbody.mass;
        float t = 2 * u / Physics.gravity.magnitude;
        Vector3 AB = b - a;
        Vector3 h = AB / t;
        Vector3 H = h * rigidbody.mass;
        Vector3 F = H + T * Vector3.up;
        rigidbody.AddForce(F, ForceMode.Impulse);
    }
}
