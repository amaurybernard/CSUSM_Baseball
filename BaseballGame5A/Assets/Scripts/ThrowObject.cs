using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    // A GameOject variable for the prefab object
    public GameObject prop;

    // A GameObject variable to store the object being thrown
    private GameObject proj;

    // A Vector3 veriable to adjust the position of the object in the character hand
    public Vector3 position;

    // A Vector3 variable to adjust the force of the object being thrown
    public Vector3 force;

    // A Transform variable for the characters hand
    public Transform hand;

    /*
     * Hold function: instatiates prop to character's hand and adjust position of prop
     */
    public void Hold()
    {
        // Instantiate the prefab object in the character's hand
        proj = Instantiate(prop, hand.position, hand.rotation) as GameObject;

        // Name the of the prop
        proj.name = "baseball";

        // Set the prop to be the child of the character's hand
        proj.transform.parent = hand;

        // Adjust the position of the prop 
        proj.transform.localPosition = position;

        // reset the prop's rotation for safety
        proj.transform.localEulerAngles = Vector3.zero;
    }

    /* 
     * Throw function: Remove prop from character's hand and adds force to prop
     */
    public void Throw()
    {
        // A vector3 variable to get the transfrom rotation of the character
        Vector3 dir = transform.rotation.eulerAngles;

        // Set the prop's rotation to equal character's rotation
        proj.transform.rotation = Quaternion.Euler(dir);
        
        // Remove prop from character's hand
        proj.transform.parent = null;
        
        // Add Rigidboby to prop
        Rigidbody rig = proj.AddComponent<Rigidbody>();

        // Add force to prop
        rig.AddRelativeForce(force);
    }
   
}
