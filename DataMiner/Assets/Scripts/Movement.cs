using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Movement")]
    public float Speed;
    public Rigidbody2D player;
    Vector3 movement;
    public Transform mouseTransform;

    [Header("Dashing")]
    private Vector2 dir;
    private float activeMoveSpeed;
    public float dashSpeed;
    public float dashLength;
    public float dashCooldown;
    private float dashCounter;
    private float dashCooldownCounter;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        mouseTransform = gameObject.transform;
        activeMoveSpeed = Speed;
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
        Rotation();
    }

    public void Moving()
    {
        var dashInput = Input.GetKeyDown(KeyCode.Space);

        movement = Vector3.zero;
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement != Vector3.zero)
        {
            player.MovePosition(transform.position + movement * activeMoveSpeed * Time.fixedDeltaTime);
        }

        if (dashInput)
        {
            Dashing();
        }

        if (dashCounter > 0)
        {
            dashCounter -= Time.deltaTime;

            if (dashCounter <= 0)
            {
                activeMoveSpeed = Speed;
                dashCooldownCounter = dashCooldown;
            }
        }

        if (dashCooldownCounter > 0)
        {
            dashCooldownCounter -= Time.deltaTime;
        }
    }

    public void Rotation()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouseTransform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle+90, Vector3.forward);
        mouseTransform.rotation = rotation;
    }

    public void Dashing()
    {
        if (dashCooldownCounter <= 0 && dashCounter <= 0)
        {
            activeMoveSpeed = dashSpeed;
            dashCounter = dashLength;
        }
    }
}
