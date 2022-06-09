using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] Player myPlayer; 
    Camera myCamera;

    void Start()
    {
        myCamera = Camera.main;
    }

   
    void Update()
    {
        float x = myPlayer.transform.position.x;
        float y = myPlayer.transform.position.y;
        float z = myCamera.transform.position.z;
        myCamera.transform.position = new Vector3(x, y, z);
    }
}
