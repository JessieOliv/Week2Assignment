using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public float hitCounter;
    // Start is called before the first frame update
    public void OnCollisionEnter(Collision collision)
    {
            hitCounter += 1;
        print("I've been hit" + hitCounter + " times");


    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
