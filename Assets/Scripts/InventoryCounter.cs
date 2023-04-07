using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryCounter : MonoBehaviour
{

    private TextMeshProUGUI seashellCounterText;



    // Start is called before the first frame update
    void Start() => seashellCounterText = GetComponent<TextMeshProUGUI>();

    public void UpdateSeashellCount(Inventory inventory)
    {
        seashellCounterText.text = inventory.seashellCount.ToString();
    }
}
