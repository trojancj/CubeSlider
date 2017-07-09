using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public Movement movement;

    void OnCollisionEnter (Collision collisionInfo){
        if(collisionInfo.collider.tag == "New tag"){
           movement.enabled = false;
           Debug.Log("We hit something.");
        }
    }

}
