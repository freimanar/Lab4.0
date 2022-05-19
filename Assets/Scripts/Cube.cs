using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Redcode.Extensions;
public class Cube : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.SetPositionZ(transform.position.z + 7f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.SetPositionZ(transform.position.z - 7f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.SetPositionX(transform.position.x + 7f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.SetPositionX(transform.position.x - 7f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.SetPositionY(transform.position.y + 10f * Time.deltaTime);
        }
    }
}