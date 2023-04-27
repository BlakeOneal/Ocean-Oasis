using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Seashell;
    public Vector3[] spawnPoints = new Vector3[20];
    public int numberSpawn = 10;

    void SpawnSeashells()
    {

        spawnPoints[0] = new Vector3((float)65, (float)0, (float)52); //D
        spawnPoints[1] = new Vector3((float)-62.3800011, (float)0, (float)18.5900002); //D
        spawnPoints[2] = new Vector3((float)90, (float)0.35, (float)10); //D
        spawnPoints[3] = new Vector3((float)80.27, (float)0, (float)124.11); //D
        spawnPoints[4] = new Vector3((float) 181.389999, (float) 10.1000004, (float) 50.4599991); //D
        spawnPoints[5] = new Vector3((float)152.57, (float)0, (float)63.915); //D
        spawnPoints[6] = new Vector3((float)90.3199997, (float)0, (float)348.959991); //D
        spawnPoints[7] = new Vector3((float) 117.599998, (float) 54.4000015, (float) -63.7999992); //D
        spawnPoints[8] = new Vector3((float)-15.6999998, (float)4.46000004, (float)-374.899994); //D
        spawnPoints[9] = new Vector3((float)246.839996, (float)80.5699997, (float)-46.7599983); //D
        spawnPoints[10] = new Vector3((float)382.412994, (float)17.406, (float)-165.296005); //D
        spawnPoints[11] = new Vector3((float)618.200012, (float)0, (float)-210.899994); //D
        spawnPoints[12] = new Vector3((float)324.799988, (float)0.74, (float)94.5999985); //D
        spawnPoints[13] = new Vector3((float)523, (float)0, (float)94.5999985); //D
        spawnPoints[14] = new Vector3((float)849, (float)0, (float)394); //D
        spawnPoints[15] = new Vector3((float) 763.5, (float) 59.4000015, (float) 75.9000015); //D
        spawnPoints[16] = new Vector3((float)721.700012, (float)0, (float)206.22); //D
        spawnPoints[17] = new Vector3((float)924.400024, (float)0, (float)355.600006); //D
        spawnPoints[18] = new Vector3((float)685, (float)0, (float)355.600006); //D
        spawnPoints[19] = new Vector3((float)225, (float)0, (float)187.300003); //D

        List<Vector3> availableSpawnPoints = new List<Vector3>(spawnPoints);

        for (int i = 0; i < 10 && availableSpawnPoints.Count > 0; i++)
        {

            int randomIndex = Random.Range(0, availableSpawnPoints.Count);
            Vector3 spawnPoint = availableSpawnPoints[randomIndex];
            Instantiate(Seashell, spawnPoint, Quaternion.identity);
            availableSpawnPoints.RemoveAt(randomIndex);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //LOCATIONS
        
        SpawnSeashells();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
