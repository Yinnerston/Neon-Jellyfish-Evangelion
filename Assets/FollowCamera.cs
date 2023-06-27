using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Position should match player's GameObject
    [SerializeField] GameObject playerToFollow;
    Vector3 cameraOffset = Vector3.forward * 10;
    void LateUpdate()
    {
        transform.position = playerToFollow.transform.position - cameraOffset;
    }
}
