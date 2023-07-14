using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicsPickup2 : MonoBehaviour
{
    //[Header("Pickup Settings")]
    //[SerializeField] Transform HoldArea;
    //private GameObject heldOBJ;
    //private Rigidbody heldOBJRB;

    //[Header("Pickup Parameters")]
    //[SerializeField] private float pickupRange = 5.0f;
    //[SerializeField] private float pickupForce = 150.0f;

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.E))
    //    {
    //        if (heldOBJ == null)
    //        {
    //            RaycastHit hit;
    //            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickupRange))
    //            {
    //                PickupObject(hit.transform.gameObject);
    //            }
    //        }
    //        else
    //        {
    //            DropObject();
    //        }
    //    }

    //    if (heldOBJ != null)
    //    {
    //        MoveObject();
    //    }
    //}

    //void MoveObject()
    //{
    //    if (Vector3.Distance(heldOBJ.transform.position, HoldArea.position) > 0.1f)
    //    {
    //        Vector3 moveDirection = (HoldArea.position - heldOBJ.transform.position);
    //        heldOBJRB.AddForce(moveDirection * pickupForce);
    //    }
    //}

    //void PickupObject(GameObject pickOBJ)
    //{
    //    Rigidbody pickOBJRB = pickOBJ.GetComponent<Rigidbody>();
    //    if (pickOBJRB != null)
    //    {
    //        heldOBJRB = pickOBJRB;
    //        heldOBJRB.useGravity = false;
    //        heldOBJRB.drag = 10;
    //        heldOBJRB.constraints = RigidbodyConstraints.FreezeRotation;

    //        heldOBJRB.transform.parent = HoldArea;
    //        heldOBJ = pickOBJ;
    //    }
    //}

    //void DropObject()
    //{
    //    heldOBJRB.useGravity = true;
    //    heldOBJRB.drag = 1;
    //    heldOBJRB.constraints = RigidbodyConstraints.None;

    //    heldOBJ.transform.parent = null;
    //    heldOBJ = null;
    //}

    //[Header("Pickup Settings")]
    //[SerializeField] Transform HoldArea;
    //private GameObject heldOBJ;
    //private Rigidbody heldOBJRB;

    //[Header("Pickup Parameters")]
    //[SerializeField] private float pickupRange = 5.0f;
    //[SerializeField] private float pickupForce = 150.0f;
    //[SerializeField] private float throwForce = 500.0f; // Atış hızını kontrol eden değişken




    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.E))
    //    {
    //        if (heldOBJ == null)
    //        {
    //            RaycastHit hit;
    //            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickupRange))
    //            {
    //                PickupObject(hit.transform.gameObject);
    //            }
    //        }
    //        else
    //        {
    //            DropObject();
    //        }
    //    }

    //    if (heldOBJ != null)
    //    {
    //        if (Input.GetMouseButtonDown(0))
    //        {
    //            ThrowObject();
    //        }
    //        else
    //        {
    //            MoveObject();
    //        }
    //    }
    //}

    //void MoveObject()
    //{
    //    if (Vector3.Distance(heldOBJ.transform.position, HoldArea.position) > 0.1f)
    //    {
    //        Vector3 moveDirection = (HoldArea.position - heldOBJ.transform.position);
    //        heldOBJRB.AddForce(moveDirection * pickupForce);
    //    }
    //}

    //void PickupObject(GameObject pickOBJ)
    //{
    //    Rigidbody pickOBJRB = pickOBJ.GetComponent<Rigidbody>();
    //    if (pickOBJRB != null)
    //    {
    //        heldOBJRB = pickOBJRB;

    //        heldOBJRB.interpolation = RigidbodyInterpolation.None; 
    //        heldOBJRB.useGravity = false;
    //        heldOBJRB.drag = 10;
    //        heldOBJRB.constraints = RigidbodyConstraints.FreezeRotation;

    //        heldOBJRB.transform.parent = HoldArea;
    //        heldOBJ = pickOBJ;
    //    }
    //}

    //void DropObject()
    //{
    //    heldOBJRB.useGravity = true;
    //    heldOBJRB.drag = 1;
    //    heldOBJRB.constraints = RigidbodyConstraints.None;
    //    heldOBJRB.interpolation = RigidbodyInterpolation.Interpolate; // Interpolate'i geri yükle

    //    heldOBJ.transform.parent = null;
    //    heldOBJ = null;
    //}

    //void ThrowObject()
    //{
    //    heldOBJRB.useGravity = true;
    //    heldOBJRB.drag = 1;
    //    heldOBJRB.constraints = RigidbodyConstraints.None;
    //    heldOBJRB.interpolation = RigidbodyInterpolation.Interpolate; // Interpolate'i ayarla

    //    heldOBJ.transform.parent = null;
    //    heldOBJRB.AddForce(transform.forward * throwForce, ForceMode.Impulse);

    //    heldOBJ = null;
    //}


    [Header("Pickup Settings")]
    [SerializeField] Transform HoldArea;
    private GameObject heldOBJ;
    private Rigidbody heldOBJRB;

    [Header("Pickup Parameters")]
    [SerializeField] private float pickupRange = 5.0f;
    [SerializeField] private float pickupForce = 150.0f;
    [SerializeField] private float throwForce = 500.0f; // Atış hızını kontrol eden değişken

    private bool isRotating = false; // Mouse rotasyonunu kontrol etmek için değişken

    [SerializeField] private MonoBehaviour scriptToControl;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (heldOBJ == null)
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickupRange))
                {
                    PickupObject(hit.transform.gameObject);
                }
            }
            else
            {
                DropObject();
            }
        }

        if (heldOBJ != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ThrowObject();
            }
            else if (Input.GetMouseButtonDown(2)) // Mouse orta tuşa basıldığında
            {
                DeactivateScript();

                StartRotating();
            }
            else if (Input.GetMouseButtonUp(2)) // Mouse orta tuş bırakıldığında
            {
                ActivateScript();

                StopRotating();
            }
            else if (isRotating) // Eğer mouse orta tuş basılıysa ve hareket ettiriliyorsa
            {
                RotateObject();
            }
            else
            {
                MoveObject();
            }
        }
    }

    void MoveObject()
    {
        if (Vector3.Distance(heldOBJ.transform.position, HoldArea.position) > 0.1f)
        {
            Vector3 moveDirection = (HoldArea.position - heldOBJ.transform.position);
            heldOBJRB.AddForce(moveDirection * pickupForce);
        }
    }

    void PickupObject(GameObject pickOBJ)
    {
        Rigidbody pickOBJRB = pickOBJ.GetComponent<Rigidbody>();
        if (pickOBJRB != null)
        {
            heldOBJRB = pickOBJRB;
            heldOBJRB.interpolation = RigidbodyInterpolation.None;
            heldOBJRB.useGravity = false;
            heldOBJRB.drag = 10;
            heldOBJRB.constraints = RigidbodyConstraints.FreezeRotation;

            heldOBJRB.transform.parent = HoldArea;
            heldOBJ = pickOBJ;
        }
    }

    void DropObject()
    {
        heldOBJRB.useGravity = true;
        heldOBJRB.drag = 1;
        heldOBJRB.constraints = RigidbodyConstraints.None;
        heldOBJRB.interpolation = RigidbodyInterpolation.Interpolate;

        heldOBJ.transform.parent = null;
        heldOBJ = null;
    }

    void ThrowObject()
    {
        heldOBJRB.useGravity = true;
        heldOBJRB.drag = 1;
        heldOBJRB.constraints = RigidbodyConstraints.None;
        heldOBJRB.interpolation = RigidbodyInterpolation.Interpolate;

        heldOBJ.transform.parent = null;
        heldOBJRB.AddForce(transform.forward * throwForce, ForceMode.Impulse);

        heldOBJ = null;
    }

    void StartRotating()
    {
        isRotating = true;
    }

    void StopRotating()
    {
        isRotating = false;
    }

    void RotateObject()
    {

        float mouseX = Input.GetAxis("Mouse X");

        Vector3 rotation = new Vector3(0f, 0f, mouseX);
        heldOBJ.transform.Rotate(rotation);
    }

    void DeactivateScript()
    {
        if (scriptToControl != null)
        {
            scriptToControl.enabled = false;
        }
    }

    void ActivateScript()
    {
        if (scriptToControl != null)
        {
            scriptToControl.enabled = true;
        }
    }
}
