using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    // declare the position of the raycast points
    [SerializeField] Transform RightPos;
    [SerializeField] Transform LeftPos;
    [SerializeField] Transform UpPos;
    [SerializeField] Transform DownPos;

    private Lightsout lightsoutScript;

    // Start is called before the first frame update
    void Start()
    {
        lightsoutScript = FindObjectOfType<Lightsout>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            // Raycast to find the closest pickup-able object from everydirection
            RaycastHit2D hitright = Physics2D.Raycast(RightPos.position, Vector2.right, 1.5f);
            RaycastHit2D hitleft = Physics2D.Raycast(LeftPos.position, Vector2.left, 1.5f);
            RaycastHit2D hitup = Physics2D.Raycast(UpPos.position, Vector2.up, 1.5f);
            RaycastHit2D hitdown = Physics2D.Raycast(DownPos.position, Vector2.down, 1.5f);


            // checking what raycast hit
            if (hitright.collider != null && hitright.collider.CompareTag("Generator"))
            {
                lightsoutScript.GeneratorON();
            }
            else if (hitleft.collider != null && hitleft.collider.CompareTag("Generator"))
            {
                lightsoutScript.GeneratorON();
            }
            else if (hitup.collider != null && hitup.collider.CompareTag("Generator"))
            {
                lightsoutScript.GeneratorON();
            }
            else if (hitdown.collider != null && hitdown.collider.CompareTag("Generator"))
            {
                lightsoutScript.GeneratorON();
            }
        }
       }
}
