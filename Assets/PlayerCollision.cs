using UnityEngine;

public class PlayerCollision : MonoBehaviour {
   
   public PlayerMovement movement;

   void OnCollisionEnter(Collision collision){
            if ( collision.collider.tag == "Wall") {
                Debug.Log("BOOM");
       }
   }
}
