using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonballEmitterScript : MonoBehaviour
{
    // cannonBall Prefab object
    public GameObject cannonBallPrefab;

    // Speed to launch cannonBall
    public float cannonVel;

    // Seconds to wait before firing cannon
    public int delay;

    // Update runs every frame
    void Update(){

      // Check keypress
      if (Input.GetKeyDown(KeyCode.Space)){

        // Shoot cannon after delay
        Invoke("ShootCannon", delay);
      }
    }

    void ShootCannon(){
      // Instantiate new cannonBall object
      GameObject cannonBall = Instantiate(cannonBallPrefab);

      // Set position to position of emitter
      cannonBall.transform.position = transform.position;

      // Rotate the cannonBall forward direction to match emitter rotation
      cannonBall.transform.rotation = transform.rotation;

      // Move cannonBall forward with cannonVel
      cannonBall.GetComponent<Rigidbody>().velocity = cannonBall.transform.forward * cannonVel;
    }

}
