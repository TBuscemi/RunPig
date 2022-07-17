using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{

    public Rigidbody2D rb;

    public float jump = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       float moveDirection = Input.GetAxis("Vertical");
       rb.velocity = new Vector2(0, moveDirection * jump);
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Obstacle")){
            Destroy(gameObject);
        }
    }
}
