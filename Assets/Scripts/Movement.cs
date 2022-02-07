using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rocketRigidbody;
    [SerializeField]float rocketLiftingSpeed=1.2f;
    private int deltaTimeValueComplement=1000;
     [SerializeField] float rocketSteeringSpeed=0.5f;
        void Start()
    {
        rocketRigidbody=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
        CantRotate();
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

  
       rocketRigidbody.AddTorque(0,0,rocketSteeringSpeed);

    }
 if(Input.GetKey(KeyCode.RightArrow)==true)
    {
   
    rocketRigidbody.AddTorque(0,0,-rocketSteeringSpeed);
    }
}
void CantRotate()
{
   Vector3 wektorBezpieczenstwa = transform.rotation.eulerAngles;
    transform.rotation = Quaternion.Euler(wektorBezpieczenstwa.x,90, 0);
}

}
