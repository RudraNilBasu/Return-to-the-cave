
using UnityEngine;
 using System.Collections;
 
 public class PlayerMove : MonoBehaviour {
     
     float speed = 5.0f;
     
     void Update() {

		if (Input.GetKeyDown (KeyCode.LeftShift)) {

			speed = 10.0f;
		}

		if (Input.GetKeyUp (KeyCode.LeftShift)) {

			speed = 5.0f;
		
		}

         var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
         transform.position += move * speed * Time.deltaTime;
     }
 }