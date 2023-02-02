using UnityEngine;

/* 
----This script moves a Rigidbody2D object based on the horizontal and vertical inputs, 
----which are typically controlled by the arrow keys or the left thumbstick on a gamepad. 
----The speed variable determines how fast the object moves.
 
 */
public class Playermovement : MonoBehaviour
{
    public float speed = 10.0f;

    private Rigidbody2D rigidBody;

    private Animator anim;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        anim.SetFloat("Movex", vertical);
        anim.SetFloat("MoveY", horizontal);

        rigidBody.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
}
