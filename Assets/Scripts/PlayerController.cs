using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    void Start()
   {
      
   }
   
     void Update()  // Add the Update function inside the class
    {
        Vector2 position = transform.position; // Store the player’s position
        position.x = position.x + 0.1f;
        transform.position = position;
    }
}
