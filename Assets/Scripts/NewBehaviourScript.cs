using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody theRB;

    public float forwardAccel = 8f, reverseAccel = 4f, maxSpeed = 50f, turnStrength = 180;

    private float speedInput, turnInput;

    // Start is called before the first frame update
    void Start()
    {
        theRB.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        speedInput = 0f;
        if(Input.GetAxis("vertical") > 0)
        {
            speedInput = Input.GetAxis("vertical") * forwardAccel * 1000f;
        } else if (speedInput.GetAxis("Vertical") < 0)
        {
            speedInput = Input.GetAxis("vertical") * reverseAccel * 1000f;
        }







        transform.position = theRB.transform.position;
    }

    private void FixedUpdate()
    {
        if(Mathf.Abs(speedInput) > 0)
        {
            theRB.AddForce(transform.forward * speedInput);
        }
        
    }

}
