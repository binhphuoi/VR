using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerrySpawn : MonoBehaviour
{
    public GameObject berry;
    public Vector3 spawnPos;
    // Start is called before the first frame update
    public float timeDelay;
    void Start()
    {
        StartCoroutine (spawn());

    }

    // Update is called once per frame
    void Update()
    {
        spawnPos = new Vector3(Random.Range(-5, 5), 1, Random.Range(-5, 5));
        
        }
    IEnumerator spawn()

    {
        while (true)
        {   GameObject berrySpawned = Instantiate(berry, spawnPos, Quaternion.identity);
            berrySpawned.GetComponent<Renderer>().material.color = Random.ColorHSV();
            yield return new WaitForSeconds(timeDelay);
            Destroy(berrySpawned);
        }
    }
}
