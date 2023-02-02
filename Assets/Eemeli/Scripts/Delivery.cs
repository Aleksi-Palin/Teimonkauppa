using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    public List<GameObject> deliveryList = new List<GameObject>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            GameObject deliveryToRetrieven = GetRandomDeliveryLocation(deliveryList);
        }
    }
    public GameObject GetRandomDeliveryLocation(List<GameObject> whereToDeliver)
    {
        int randomNum = Random.Range(0, whereToDeliver.Count);
        print(randomNum);
        GameObject printRandom = whereToDeliver[randomNum];
        print(printRandom);
        return printRandom;
    }
}
