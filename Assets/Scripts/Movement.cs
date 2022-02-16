using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

 Rigidbody rocketRigidbody;
  AudioSource rocketBoost;

    [SerializeField]float rocketLiftingSpeed=1.3f;
    private int deltaTimeValueComplement=1000;
     [SerializeField] float rocketSteeringSpeed=0.2f;
        void Start()
    {
        rocketRigidbody=GetComponent<Rigidbody>();
        rocketBoost=GetComponent<AudioSource>();
    }

    
    void Update()
    {
         rocketRigidbody.transform.position= new Vector3(transform.position.x, transform.position.y, 0); // out of the course
        ProcessThrust();
        ProcessRotation();
   
    }

void ProcessThrust()
{
    if(Input.GetKey(KeyCode.UpArrow)==true)
    {
     
     
     rocketRigidbody.AddRelativeForce( Vector3.up *rocketLiftingSpeed *Time.deltaTime* deltaTimeValueComplement );
      if(!rocketBoost.isPlaying)
      {
      rocketBoost.Play();
      }
     
    }
    else
    {
rocketBoost.Stop();

    }
}
void ProcessRotation()
{
 if(Input.GetKey(KeyCode.LeftArrow)==true)
        {
            ApplyRotation(1);
        }
        else if(Input.GetKey(KeyCode.RightArrow)==true)
    {
         ApplyRotation(-1);
    }
}

    private void ApplyRotation(int direction)
    {
        rocketRigidbody.freezeRotation=true;
        transform.Rotate(Vector3.forward * rocketSteeringSpeed * Time.deltaTime * deltaTimeValueComplement* direction);
        
    
     rocketRigidbody.constraints= RigidbodyConstraints.FreezeRotationX | 
            RigidbodyConstraints.FreezeRotationY | 
            RigidbodyConstraints.FreezePositionZ; // out of the course/ will freez rotation after player change  

    }
}
