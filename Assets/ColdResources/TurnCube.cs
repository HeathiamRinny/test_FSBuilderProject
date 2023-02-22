using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnCube : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private float speed;

    void Update()
    {
        cube.transform.Rotate(Vector3.up, speed* Time.deltaTime);
    }
}
