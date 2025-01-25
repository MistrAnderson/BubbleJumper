using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1;
    public void movement(float direction)
    {
        Vector2 v = new Vector2(direction, 0);
        transform.Translate(v * speed * Time.deltaTime);
    }
}
