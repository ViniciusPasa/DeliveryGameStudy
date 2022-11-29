using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] GameObject FollowCar;
    void LateUpdate()
    {
        transform.position = FollowCar.transform.position + new Vector3(0,0,-10);
    }
}
