using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seashell : MonoBehaviour
{
    
    public void OnTriggerEnter(Collider other)
    {

        Inventory inventory = other.GetComponent<Inventory>();

        if (inventory != null)
        {
            inventory.CollectSeashell();
            gameObject.SetActive(false);
        }
    }
}
