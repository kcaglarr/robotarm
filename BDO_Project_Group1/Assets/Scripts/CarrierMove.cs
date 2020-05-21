using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrierMove : MonoBehaviour
{
    Vector3 _offset = new Vector3(0f, 1.0f, 0f);
    //public Plane hPlane;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update() {

        /*
        if (Input.GetKey(KeyCode.R)) {

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f)) {
                if (hit.transform && (hit.transform.name == "Plane")) {
                    ray.
                    this.transform.position = ray.GetPoint() + temp;
                    
                }
            }
        }
        */
        if (Input.GetKey(KeyCode.R)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // create a plane at 0,0,0 whose normal points to +Y:
            Plane hPlane = new Plane(Vector3.up, Vector3.zero);
            // Plane.Raycast stores the distance from ray.origin to the hit point in this variable:
            float distance = 0;
            // if the ray hits the plane...
            if (hPlane.Raycast(ray, out distance)) {
                // get the hit point:
                this.transform.position = ray.GetPoint(distance) + _offset;

            }
        }
        
    }
}
