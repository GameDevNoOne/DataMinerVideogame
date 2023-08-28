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

    [Header("Respawning")]
    public Transform respawnPoint;
    public int collectedInfoBits;
    public int collectedLocBits;
    public int i;
    public int oldi = 0;
    public GameObject inputManager;

    public void Awake()
    {
        gameObject.transform.position = respawnPoint.position;
    }

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
        i = inputManager.GetComponent<InputManager>().i;
        Moving();
        Rotation();
        if (i == oldi+1)
        {
            collectedInfoBits = 0;
            collectedLocBits = 0;
            gameObject.transform.position = respawnPoint.position;
            oldi += 1;
        }
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

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Information"))
        {
            collectedInfoBits+=1;
        }
        if (collision.transform.CompareTag("Location"))
        {
            collectedLocBits+=1;
        }
    }
}
