using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderObject : InteractiveObject
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && playerInRange)
        {
            Player.currentState = Player.PlayerState.CLIMBING;
        }
        else if (!playerInRange)
        {
            Player.currentState = Player.PlayerState.WANDER;

        }
    }

    void OpenDoor()
    {
        Player.currentState = Player.PlayerState.CLIMBING;
    }
}
