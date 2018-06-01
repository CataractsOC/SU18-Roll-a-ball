using UnityEngine;
using System.Collections;

public class TrackingCamera : MonoBehaviour {
    public Transform target;

    void Update()
    {
        transform.LookAt(target);
    }
}