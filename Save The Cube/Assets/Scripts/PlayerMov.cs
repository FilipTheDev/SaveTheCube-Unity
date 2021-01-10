using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{

public Rigidbody rb;
public float forwardForce = 2000f;
public float sideForce = 500f;

    // Start is called before the first frame update


    // Update
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") || Input.GetKey("right")) {
          rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( Input.GetKey("a")  || Input.GetKey("left") ) {
          rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f) {
          FindObjectOfType<GameManager>().EndGame();

        }


    }
}
