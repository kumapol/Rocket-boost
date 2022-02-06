using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
     Debug.Log("Spacja") ;  
    }
}
void ProcessRotation()
{
 if(Input.GetKey(KeyCode.LeftArrow)==true)
    {
     Debug.Log("lewa") ;  
    }
 if(Input.GetKey(KeyCode.RightArrow)==true)
    {
     Debug.Log("prawa") ;  
    }
}

}
