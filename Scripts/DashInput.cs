using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DahsInput : MonoBehaviour
{
    Dash dash;
    int dashNumber = 1;

    private void Awake()
    {
        dash = GetComponent<Dash>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && dashNumber >= 1 && Input.GetKeyDown(KeyCode.D))
        {
            dash.dashRight();
            dashNumber = dashNumber - 1;
        }
        if (Input.GetKeyDown(KeyCode.RightShift) && dashNumber <= 1 && Input.GetKeyDown(KeyCode.Q))
        {
            dash.dashLeft();
            dashNumber = dashNumber - 1;
        }
    }
    void OnCollisionEnter2D()
    {
        if (dashNumber <= 0)
        {
            dashNumber = dashNumber + 1;
        }
    }
}
