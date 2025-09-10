using UnityEditor.Rendering;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float speed;
    void Start()
    {
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontalInput, verticalInput);

        transform.Translate(movement * Time.deltaTime * speed);
    }
}
