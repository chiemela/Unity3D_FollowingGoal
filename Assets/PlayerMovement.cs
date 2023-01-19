using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public int mystate;
    public float turnspeed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10.0f;
        mystate = 1;
    }

    // FixedUpdate is called once per frame
    void FixedUpdate()
    {
        float rotation = Input.GetAxis("Horizontal") * turnspeed;   // < > arrow or A and D
        float translation = Input.GetAxis("Vertical") * speed;  // \/ /\ arrows or W and S

        transform.Rotate(0, rotation * Time.deltaTime, 0);
        transform.Translate(0, 0, translation * Time.deltaTime);
    }
}
