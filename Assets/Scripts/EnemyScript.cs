using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private Rigidbody rb;
    float direction = 0.5f;
    public int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if (counter == 1000)
        {
            direction = direction * -1;
            counter = -1000;
        }
        rb.AddForce(transform.right * direction);
    }
}
