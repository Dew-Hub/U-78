using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class gravityGun : MonoBehaviour
{
    private Transform PickUpPoint;
    private Transform player;

    public float pickUpDistance;
    public float throwForce;

    public bool itemIsPicked;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player").transform;
        PickUpPoint = GameObject.Find("PickUpPoint").transform;
    }

    private void Update()
    {
        pickUpDistance = Vector3.Distance(player.position, transform.position);

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!itemIsPicked && pickUpDistance <= 2 && PickUpPoint.childCount < 1)
            {
                PickUpObject();
            }
            else if (itemIsPicked)
            {
                ReleaseObject();
            }
        }

        if (itemIsPicked && Input.GetMouseButtonDown(0))
        {
            ThrowObject();
        }
    }

    private void PickUpObject()
    {
        rb.useGravity = false;
        rb.isKinematic = true;
        transform.position = PickUpPoint.position;
        transform.parent = PickUpPoint;

        itemIsPicked = true;
    }

    private void ReleaseObject()
    {
        rb.isKinematic = false;
        transform.parent = null;
        rb.useGravity = true;

        itemIsPicked = false;
    }

    private void ThrowObject()
    {
        rb.isKinematic = false;
        transform.parent = null;
        rb.useGravity = true;
        rb.AddForce(player.forward * throwForce, ForceMode.Impulse);

        itemIsPicked = false;
    }
}
