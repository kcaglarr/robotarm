using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RobotArmCarry : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject cube;
    void Start()
    {

    }
    private void HoldCube() {
        if (!cube) {
            return;
        }
        cube.transform.position = this.transform.position;

        Vector3 temp = new Vector3(0f, -1.0f, 0f);
        //cube.transform.position += temp;
        
        
        Vector3 mychildtransform = this.transform.Find("ArmCarrier").position;
        cube.transform.position = mychildtransform + temp;
        cube.GetComponent<Rigidbody>().useGravity = false;
        //cube.GetComponent<Rigidbody>().isKinematic = false;
        //cube.GetComponent<Rigidbody>().freezeRotation = true;
    }
    private void DropCube() {
        cube.GetComponent<Rigidbody>().useGravity = true;
        //cube.GetComponent<Rigidbody>().isKinematic = true;
        //cube.GetComponent<Rigidbody>().freezeRotation = false;
    }
    int flag = 0;//kötü kod

    // Update is called once per frame
    void Update()
    {
        //HoldCube();
        
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit, 100.0f)) {
            if (hit.transform && (hit.transform.name != "Plane" && hit.transform.name != "RobotArm" && hit.transform.name != "Carrier")) {
                cube = hit.transform.gameObject;
            }
        }
        
        if (Input.GetKey(KeyCode.E) || flag == 1) {
            flag = 1;
            HoldCube();
        }
        if (Input.GetKeyDown(KeyCode.F)) {
            flag = 0;
            DropCube();
        }
    }
}
