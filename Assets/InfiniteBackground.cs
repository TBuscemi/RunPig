using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteBackground : MonoBehaviour
{
    public BoxCollider2D collider;
    public Rigidbody2D rb;

    public float width;

    public float scrollSpeed = -20f;
    void Start()
    {
        collider = GetComponent < BoxCollider2D>();
        rb = GetComponent < Rigidbody2D>();

        width = collider.size.x;
        collider.enabled = false;

        rb.velocity=new Vector2(scrollSpeed, 0);

        ResetObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -width){
            Vector2 resetPosition = new Vector2(width * 2f, 0);
            transform.position = (Vector2)transform.position + resetPosition;
            ResetObstacle();
        };
        
    }

    void ResetObstacle(){
        transform.GetChild(0).localPosition = new Vector3(Random.Range(16,30), Random.Range(-10,-5), 0);
        transform.GetChild(1).localPosition = new Vector3(Random.Range(16,30), Random.Range(-10,-5), 0);
        transform.GetChild(2).localPosition = new Vector3(Random.Range(16,30), Random.Range(-10,-5), 0);
        transform.GetChild(3).localPosition = new Vector3(Random.Range(16,30), Random.Range(-10,-5), 0);
        transform.GetChild(4).localPosition = new Vector3(Random.Range(16,30), Random.Range(-10,-5), 0);
        transform.GetChild(5).localPosition = new Vector3(Random.Range(16,30), Random.Range(-10,-5), 0);
        transform.GetChild(6).localPosition = new Vector3(Random.Range(16,30), Random.Range(-10,-5), 0);
    }
}
