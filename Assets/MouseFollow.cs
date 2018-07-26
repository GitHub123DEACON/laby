
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    Vector2 lookDirection;
    Vector2 smoothingVector;
    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;
    GameObject character;
    // Use this for initialization
    void Start()
    {
        character = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseDirection = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")); //
        mouseDirection = Vector2.Scale(mouseDirection, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothingVector.x = Mathf.Lerp(smoothingVector.x, mouseDirection.x, 1f / smoothing);
        smoothingVector.y = Mathf.Lerp(smoothingVector.y, mouseDirection.y, 1f / smoothing);
        lookDirection += smoothingVector;
        lookDirection.y = Mathf.Clamp(lookDirection.y, -30f, 10f);
        transform.localRotation = Quaternion.AngleAxis(-lookDirection.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(lookDirection.x, character.transform.up);

    }
}