using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody Rb;

    public float forwardForce = 200f;

    public float sidewaysForce = 50f;

    // FixedUpdate is better for physics event
    void FixedUpdate()
    {
        // Add a forward force
        //Rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        
        Rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            Rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            Rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
 