using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Inventory : MonoBehaviour
{
    public int seashellCount
    {
        get;

        private set;
    }

    public UnityEvent<Inventory> DuringCollectSeashell;


        public void CollectSeashell()
        {
            seashellCount++;
        DuringCollectSeashell.Invoke(this);
        }

}
