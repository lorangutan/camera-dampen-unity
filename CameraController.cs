using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform Follower = null;
    [SerializeField]
    private Transform Target = null;
    [SerializeField]
    private float dampFollow = 0;

    public Vector3 offset;

    void LateUpdate()
    {
        Vector3 desiredPos = Target.position + offset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, dampFollow);

        //to restrict the follower from moving in an axis just pass 0 as the parameter
        //for 2D unity user Follower.position.z as the third parameter instead of smoothedPos.z
        smoothedPos.Set(smoothedPos.x,smoothedPos.y, smoothedPos.z);

        transform.position = smoothedPos;
    }
}
