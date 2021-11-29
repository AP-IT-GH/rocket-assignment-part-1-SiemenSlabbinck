using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    private Rigidbody rb;
    public float m_Thrust = 50f;
    public float m_Turn = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.transform.Rotate(0, 0, -(m_Turn));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.transform.Rotate(0, 0, m_Turn);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.up * m_Thrust);
        }
    }
}
