using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//This code allows you to do deliveries by going to certain area and pressing E. Then you will be shown a position where to deliver the food
public class Delivery : MonoBehaviour
{
    //Setting up basic things
    public List<GameObject> deliveryList = new List<GameObject>();
    bool isTriggered = false;
    private GameObject deliveryToRetrieve;

    public bool HasPickedDelivery;

    public GameObject targetSelf;

    private void Start()
    {
        targetSelf = null;
    }

    //Updating if player has entered to pickup area and pressed E
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isTriggered == true && !HasPickedDelivery)
        {
            deliveryToRetrieve = GetRandomDeliveryLocation(deliveryList);
            targetSelf = deliveryToRetrieve;
            Debug.Log(deliveryToRetrieve);
            deliveryToRetrieve.gameObject.SetActive(true);
            HasPickedDelivery = true;

            
        }
       
    }
    //If player enters the pick up area then istriggered is true
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            isTriggered = true;
        }
    }
    //If pleyer leaves the are istriggered is set to false and we remove the old
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            isTriggered = false;
        }
    }
    public GameObject GetRandomDeliveryLocation(List<GameObject> whereToDeliver)
    {
        int randomNum = Random.Range(0, whereToDeliver.Count);
        GameObject printRandom = whereToDeliver[randomNum];
        return printRandom;
    }
}
