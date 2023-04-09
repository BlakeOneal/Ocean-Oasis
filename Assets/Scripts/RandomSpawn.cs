using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic; 

public class RandomSpawn : MonoBehaviour
{

    public GameObject objectPrefab; 
    public const int objectCount = 10;
    public List<Vector3> spawnLocations = new List<Vector3>();

    // 20 (10*2) locations shells can spawn at.
    //spawnLocations.Add(new Vector3(56.8542175,30.346138,46.7245636));
    //spawnLocations.Add(new Vector3(-381,30,129));
    //spawnLocations.Add(new Vector3(-269.899994,30.2999992,46.7245636));
    //spawnLocations.Add(new Vector3(-172,30,370));
    //spawnLocations.Add(new Vector3(54.9000015,30,214.600006));
    //spawnLocations.Add(new Vector3(230.600006,30,370));
    //spawnLocations.Add(new Vector3(310.5,30,253.600006));
    //spawnLocations.Add(new Vector3(440.299988,30,163.399994));
    //spawnLocations.Add(new Vector3(440.299988,30,53.0999985));
    //spawnLocations.Add(new Vector3(296.299988,30,53.0999985));
    //spawnLocations.Add(new Vector3(253.5,30,78.0999985));
    //spawnLocations.Add(new Vector3(25.2999992,30,-72.3000031));
    //spawnLocations.Add(new Vector3(-42.4000015,30,-174));
    //spawnLocations.Add(new Vector3(-78,30,-321));
    //spawnLocations.Add(new Vector3(14,30,-364));
    //spawnLocations.Add(new Vector3(-81.8000031,30,-66.1999969));
    //spawnLocations.Add(new Vector3(-402,30,366));
    //spawnLocations.Add(new Vector3(-291,30,290));
    //spawnLocations.Add(new Vector3(-118.300003,30,327.100006));
    //spawnLocations.Add(new Vector3(-209.300003,30,-137.399994));

    void Start()
    {
        if (spawnLocations.Count == 0)
        {
            Debug.LogWarning("There are no spawn positions set.");
            return;
        }

        for (int i = 0; i < objectCount; i++)
        {
            Vector3 spawnPosition = GetRandomSpawnPosition();

            if (spawnPosition == Vector3.zero)
            {
                Debug.LogWarning("All spawn positions have been used.");
                break;
            }

            Instantiate(objectPrefab, spawnPosition, Quaternion.identity);

            // Remove the used position from the list
            spawnLocations.Remove(spawnPosition);
        }
    }

    Vector3 GetRandomSpawnPosition()
    {
        int maxAttempts = spawnLocations.Count;
        int attempt = 0;
        Vector3 spawnPosition = Vector3.zero;

        do
        {
            int randomIndex = Random.Range(0, spawnLocations.Count);
            spawnPosition = spawnLocations[randomIndex];
            attempt++;

        } while (spawnPosition == Vector3.zero && attempt < maxAttempts);

        return spawnPosition;
    }

    void Awake()
    {
        // Make this object persistent across scene changes
        DontDestroyOnLoad(this.gameObject);
    }
}
