using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        Launch();
    }

    public void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 2;
        float y = Random.Range(0, 2) == 0 ? -1 : 2;
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
