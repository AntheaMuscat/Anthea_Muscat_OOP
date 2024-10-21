using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject BallPrefab;
    public static int NumOfBalls = 0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && NumOfBalls < 5) //0 means left-click
        {
            Vector3 mousePosition = Input.mousePosition; //get mouse location

            //convert from screen space to world space
            Vector3 inWorldSpace = Camera.main.ScreenToWorldPoint(mousePosition);
            inWorldSpace.z = 0;

            //spawn a ball using prefab
            Instantiate(BallPrefab, inWorldSpace, Quaternion.identity);
            NumOfBalls++;
        }
    }
}
