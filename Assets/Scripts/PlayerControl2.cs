using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl2 : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.O;
    public KeyCode moveDown = KeyCode.L;
    public float speed = 10.0f;
    public Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    

    // Update is called once per frame
    void Update()
    {
        var vel = rb2D.velocity;
        if (Input.GetKey(moveUp)){
            vel.y = speed;
        }
        else if (Input.GetKey(moveDown)){
            vel.y = -speed;
        }
        else{
            vel.y = 0;
        }
        rb2D.velocity = vel;

    }

}
