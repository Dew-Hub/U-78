using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ortalazeranimation : MonoBehaviour
{
    public float rotationSpeed = 50f;

    private void Update()
    {
        // Nesnenin Z rotasyonunu arttırma
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}
