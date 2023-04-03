using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public KeyCode moveUp1 = KeyCode.W;
    public KeyCode moveDown1 = KeyCode.S;
    public float speed = 10.0f;
    public Rigidbody2D rb2d;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb2d.velocity;
        if (Input.GetKey(moveUp1)){
            vel.y = speed;
        }
        else if (Input.GetKey(moveDown1)){
            vel.y = -speed;
        }
        else{
            vel.y = 0;
        }
        rb2d.velocity = vel;

        /*var pos = transform.position;
        if(pos.y > boundY){
            pos.y = boundY;
        }
        else if(pos.y < -boundY){
            pos.y = -boundY;
        }
        transform.position = pos;
        */

        
        
    }
}
