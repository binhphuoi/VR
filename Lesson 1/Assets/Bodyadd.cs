using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bodyadd : MonoBehaviour
{
    public GameObject bodypre;
    private List<GameObject> bodyPart = new List<GameObject>();
    private List<Vector3> positionHistory = new List<Vector3>();
    private int gap = 5;
    private float bodySpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void growBody()
    {
        GameObject Body = Instantiate(bodypre, transform.position, Quaternion.identity);
        bodyPart.Add(Body);
    }
}