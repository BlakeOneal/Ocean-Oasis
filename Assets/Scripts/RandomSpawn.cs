using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic; 

public class RandomSpawn : MonoBehaviour
{

    public GameObject objectPrefab; 
    public const int objectCount = 10;
    List<Vector3> spawnLocations = new List<Vector3>();

    void Start()
    {
        spawnLocations.Add(new Vector3(56.8542175f, 0, 46.7245636f));
        spawnLocations.Add(new Vector3(-381, 0, 129));
        spawnLocations.Add(new Vector3(-269.899994f,0, 46.7245636f));
        spawnLocations.Add(new Vector3(-172, 0, 370));
        //spawnLocations.Add(new Vector3(54.9000015f,30,214.600006));
        spawnLocations.Add(new Vector3(230.600006f,0, 370));
        spawnLocations.Add(new Vector3(310.5f,0,253.600006f));
        spawnLocations.Add(new Vector3(440.299988f,0,163.399994f));
        spawnLocations.Add(new Vector3(440.299988f,0,53.0999985f));
        spawnLocations.Add(new Vector3(296.299988f,0,53.0999985f));
        spawnLocations.Add(new Vector3(253.5f,0,78.0999985f));
        spawnLocations.Add(new Vector3(25.2999992f,0,-72.3000031f));
        spawnLocations.Add(new Vector3(-42.4000015f,0,-174));
        spawnLocations.Add(new Vector3(-78,0,-321));
        spawnLocations.Add(new Vector3(14,00,-364));
        spawnLocations.Add(new Vector3(-81.8000031f,0,-66.1999969f));
        spawnLocations.Add(new Vector3(-402,0,366));
        spawnLocations.Add(new Vector3(-291,0,290));
        spawnLocations.Add(new Vector3(-118.300003f,0,327.100006f));
        spawnLocations.Add(new Vector3(-209.300003f,0,-137.399994f));
        if (spawnLocations.Count == 0)
        {
            Debug.LogWarning("There are no spawn positions set.");
            return;
        }

        for (int i = 0; i < objectCount; i++)
        {
            int randomIndex = Random.Range(0, spawnLocations.Count);
            
            Vector3 spawnPosition = spawnLocations[randomIndex];

            Instantiate(objectPrefab, spawnPosition, objectPrefab.transform.rotation);

            // Remove the used position from the list
            spawnLocations.Remove(spawnPosition);
        }
    }

  
    void Awake()
    {
        // Make this object persistent across scene changes
        DontDestroyOnLoad(this.gameObject);
    }
}
