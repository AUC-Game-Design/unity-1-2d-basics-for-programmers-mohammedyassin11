using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerControllerTutorialUpdates : MonoBehaviour
{

   public InputAction MoveAction;

// Start is called before the first frame update
void Start()
{
    // QualitySettings.vSyncCount = 0;
    //  Application.targetFrameRate = 10;

MoveAction.Enable();


}


// Update is called once per frame
void Update()
{
    {
     Vector2 move = MoveAction.ReadValue<Vector2>();
     Debug.Log(move);
     Vector2 position = (Vector2)transform.position + move * 3.0f * Time.deltaTime;
     transform.position = position;
   }
}

}

