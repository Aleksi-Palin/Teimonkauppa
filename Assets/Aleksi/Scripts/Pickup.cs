using Unity.Burst.CompilerServices;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Transform carryTransform;
    private Transform holdTransform;

    // declare the position of the raycast points
    [SerializeField] Transform RightPos;
    [SerializeField] Transform LeftPos;
    [SerializeField] Transform UpPos;
    [SerializeField] Transform DownPos;

    void Start()
    {
        // Create a child GameObject to serve as the carry point
        carryTransform = new GameObject().transform;
        carryTransform.name = "Carry Point";
        carryTransform.SetParent(transform);
        carryTransform.position = new Vector3(2, 0, 0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // If an object is being held, drop it
            if (holdTransform != null)
            {
                holdTransform.SetParent(null);
                holdTransform = null;
                return;
            }

            
            // Raycast to find the closest pickup-able object from everydirection
            RaycastHit2D hitright = Physics2D.Raycast(RightPos.position, Vector2.right, 1.5f);
            RaycastHit2D hitleft = Physics2D.Raycast(LeftPos.position, Vector2.left, 1.5f);
            RaycastHit2D hitup = Physics2D.Raycast(UpPos.position, Vector2.up, 1.5f);
            RaycastHit2D hitdown = Physics2D.Raycast(DownPos.position, Vector2.down, 1.5f);


            // checking what raycast hit
            if (hitright.collider != null  && hitright.collider.CompareTag("Pickup"))
            {
                holdTransform = hitright.transform;
                holdTransform.SetParent(carryTransform);
                holdTransform.position = carryTransform.position;
            }
            else if(hitleft.collider != null && hitleft.collider.CompareTag("Pickup"))
            {
                holdTransform = hitleft.transform;
                holdTransform.SetParent(carryTransform);
                holdTransform.position = carryTransform.position;
            }
            else if(hitup.collider != null && hitup.collider.CompareTag("Pickup"))
            {
                holdTransform = hitup.transform;
                holdTransform.SetParent(carryTransform);
                holdTransform.position = carryTransform.position;
            }
            else if (hitdown.collider != null && hitdown.collider.CompareTag("Pickup"))
            {
                holdTransform = hitdown.transform;
                holdTransform.SetParent(carryTransform);
                holdTransform.position = carryTransform.position;
            }
        }
    }



}