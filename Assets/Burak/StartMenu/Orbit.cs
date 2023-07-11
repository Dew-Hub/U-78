using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform Target;
    public float speed = 50f;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Target.position, Vector3.up, speed * Time.deltaTime);
    }
}
