using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Self : MonoBehaviour
{
    public Delivery delivery;


  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("plsdsd");
        if(delivery.targetSelf.name == collision.name )
        {
            delivery.targetSelf.SetActive(false);
        }
    }
}
