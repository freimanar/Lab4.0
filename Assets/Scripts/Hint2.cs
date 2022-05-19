using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Hint2 : MonoBehaviour
{
    public UnityEngine.UI.Text txt;
    public Transform player;
    public float needDistance = 2;
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            PickUp2();
        }
        if (Vector3.Distance(transform.position, player.position) > needDistance)
        {
            txt.text = string.Empty;
        }
    }
    void PickUp2()
    {
        if (Vector3.Distance(transform.position, player.position) < needDistance)
        {
            txt.text = "Чтобы управлять кубиком, нажимайте: WASD";
        }
    }
}