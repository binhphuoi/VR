using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10f;
    public Vector3 movement;
    public int score=0;
    public Text ScoreNum;
    public float angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");
        movement.y = 0f;
        doiHuong();
    }
    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + movement * speed * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if(other.tag == "Berry")
        {
            score++;
            Debug.Log ("a");
            ScoreNum.text = score.ToString();
            Destroy(other.gameObject);
            GetComponent<Bodyadd>().growBody();
        }
       
    }
    private void doiHuong()
    { if (Input.GetAxisRaw("Horizontal") !=0 || Input.GetAxisRaw("Vertical") != 0)
        { angle = Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg;
            Quaternion targetDir = Quaternion.AngleAxis(angle, Vector3.up);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetDir, 0.1f);
        } }    
}
