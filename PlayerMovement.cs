using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    public float rotationSpeed;
    public float jumpForce;


    Rigidbody playerRigi;

    Vector3 moveInput;
    float rotateInput;


    // Player Control
    public bool isAlive = true;

    void Start()
    {
        playerRigi = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (!isAlive)
        {
            return;
        }

        Vector3 movement = transform.right * moveInput.x * Time.fixedDeltaTime + transform.forward * moveInput.y * Time.fixedDeltaTime;
        playerRigi.linearVelocity = new Vector3(movement.x * moveSpeed, playerRigi.linearVelocity.y, movement.z * moveSpeed);

        RotatePlayer();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnRotate(InputValue value)
    {
        rotateInput = value.Get<float>();
    }

    void RotatePlayer()
    {
        float rotationAmount = rotateInput * rotationSpeed * Time.fixedDeltaTime;

        Quaternion rotation = Quaternion.Euler(0f, rotationAmount, 0f);

        playerRigi.MoveRotation(playerRigi.rotation * rotation);
    }


    bool isGrounded = true;
    public void OnJump(InputValue value)
    {
        if (!isAlive)
        {
            return;
        }        
        if (value.isPressed && isGrounded)
        {
            playerRigi.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            AudioManager.Instance.JumpSound();
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Track"))
        {
            isGrounded = true;
        }
    }


}
