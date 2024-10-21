using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // Right mouse button click
        {
            // Convert the mouse position from screen space to world space
            Vector3 mousePosition = Input.mousePosition;
            Vector3 inWorldSpace = Camera.main.ScreenToWorldPoint(mousePosition);

            // Ensure the z position is zero since we're working in 2D or a flat plane
            inWorldSpace.z = 0;

            // Calculate the distance between the ball's position and the mouse click position
            float distance = Vector3.Distance(inWorldSpace, this.gameObject.transform.position);

            // If the click is close enough to the ball, destroy it
            if (distance < 0.5f)
            {
                Destroy(this.gameObject);
                Spawning.NumOfBalls--;
            }
        }
    }
}
