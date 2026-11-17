using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Houses : MonoBehaviour
{
    public LayerMask layer;

    public float rotatespeed = 60f;

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1000f, layer))
            transform.position = hit.point;

        if(Input.GetMouseButtonDown(0))
        {
        gameObject.GetComponent<AutoCarCreate>().enabled = true;
        Destroy(gameObject.GetComponent<Houses>());

        }

        if(Input.GetKey(KeyCode.LeftShift))
        transform.Rotate(Vector3.up * Time.deltaTime * rotatespeed);
    }

   
}
