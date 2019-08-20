using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMove : MonoBehaviour
{
    [SerializeField]
    private Vector3 speed = default;

    private void Update()
    {
        transform.position += speed * Time.deltaTime;
    }

}
