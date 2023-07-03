using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDash : MonoBehaviour
{
    [SerializeField] private float dashDistance = 5f;
    [SerializeField] private float dashDuration = 0.2f;
    [SerializeField] private float dashCooldown = 1f;

    private bool isDashing = false;
    private float dashTimer = 0f;
    private float dashCooldownTimer = 0f;
    private Vector3 dashDirection;

    private CharacterController characterController;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (!isDashing)
        {
            HandleDashInput();
        }
        else
        {
            HandleDash();
        }

        UpdateTimers();
    }

    private void HandleDashInput()
    {
        if (Input.GetKeyDown(KeyCode.Q) && dashCooldownTimer <= 0f)
        {
            dashDirection = transform.forward;
            isDashing = true;
            dashTimer = dashDuration;
            dashCooldownTimer = dashCooldown;
        }
    }

    private void HandleDash()
    {
        characterController.Move(dashDirection * dashDistance * (dashTimer / dashDuration));

        dashTimer -= Time.deltaTime;

        if (dashTimer <= 0f)
        {
            isDashing = false;
        }
    }

    private void UpdateTimers()
    {
        if (dashCooldownTimer > 0f)
        {
            dashCooldownTimer -= Time.deltaTime;
        }
    }
}
