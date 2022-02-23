using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed = 10;
    public int rotationSpeed = 100;
    void Update()
    {
        int translation = Input.GetAxis("Vertical") * speed;
        int rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        Transform.rotate(0, 0, translation);

    }
}
