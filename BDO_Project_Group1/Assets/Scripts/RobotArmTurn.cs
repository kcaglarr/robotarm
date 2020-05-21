using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RobotArmTurn : MonoBehaviour
{
    public float speed = 50.0f;
    public float xAngle, yAngle, zAngle;

    private string m_TurnAxisName;
    private float m_TurnInputValue;
    
    public float m_TurnSpeed = 180f;
    void Update() {

        m_TurnInputValue = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate() {
        // Move and turn the tank.
        
        Turn();
    }
    private void Turn() {
        
        float turn = m_TurnInputValue * m_TurnSpeed * Time.deltaTime;
        
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        this.GetComponent<Rigidbody>().MoveRotation(this.GetComponent<Rigidbody>().rotation * turnRotation);
    }
}
