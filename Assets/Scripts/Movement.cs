using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rocketRigidbody;
    [SerializeField]float rocketLiftingSpeed=1.2f;
    private int deltaTimeValueComplement=1000;
    // [SerializeField] float rocketSteeringSpeed=0.5f;
        void Start()
    {
        rocketRigidbody=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

void ProcessThrust()
{
    if(Input.GetKey(KeyCode.UpArrow)==true)
    {
     rocketRigidbody.AddRelativeForce( Vector3.up *rocketLiftingSpeed *Time.deltaTime* deltaTimeValueComplement );
    }
}
void ProcessRotation()
{
 if(Input.GetKey(KeyCode.LeftArrow)==true)
    {

    //rocketRigidbody.AddRelativeForce(-rocketSteeringSpeed,0,0);
     

    }
 if(Input.GetKey(KeyCode.RightArrow)==true)
    {
     //rocketRigidbody.AddRelativeForce(rocketSteeringSpeed,0,0);
    
    }
}

}
