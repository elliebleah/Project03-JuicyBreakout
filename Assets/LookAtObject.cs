using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtObject : MonoBehaviour
{
    // Reference to the GameObject to look at
    public Transform targetObject;

    // Update is called once per frame
    void Update()
    {
        if (targetObject != null)
        {
            // Get the direction from this object to the target object
            Vector3 direction = targetObject.position - transform.position;
            direction.Normalize();

            // Calculate the angle from the direction
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            // Adjust the angle to ensure correct rotation in Unity's coordinate system
            angle -= 90f;

            // Rotate the object to face the target object
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}
