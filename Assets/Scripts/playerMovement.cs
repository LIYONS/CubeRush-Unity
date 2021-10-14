using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;//Refers to rigidbody component rb
    
    public float forwardForce=2000f;
    public float sidewaysForce=700f;
    
    //Always use FixedUpdate when we are messing with physics]
    void FixedUpdate()
    {
        //Applying force to z axis 2000 
         rb.AddForce(0,0,forwardForce* Time.deltaTime);

        if(Input.GetKey("d") | Input.GetKey("right")  | ((Screen.width/2 < Input.mousePosition.x) && Input.GetMouseButton(0)) ) {
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a") | Input.GetKey("left") | ((Input.mousePosition.x < Screen.width/2) && Input.GetMouseButton(0))) {
            rb.AddForce(-sidewaysForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
