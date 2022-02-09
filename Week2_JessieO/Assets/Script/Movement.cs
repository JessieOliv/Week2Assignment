using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int moveSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.right; //if the player hits the right arrow key. the object moves right

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.left; //press left arrow to move left    

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.forward; // press up arrow to move forward

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.back; // press down arrow to move back
        }
    }
}