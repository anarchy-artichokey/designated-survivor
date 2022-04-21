using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**public class fpsMouseLook : MonoBehaviour
{
    // Start is called before the first frame update
*    void Start()
    {
        Vector3 euler = transform.rotation.eulerAngles;
        x = euler.x;
        y = euler.y;
    }

    // Update is called once per frame
    void Update()
    {
        x += Input.GetAxis("Mouse Y") * Time.deltaTime;
        y += Input.GetAxis("Mouse X") *  Time.deltaTime;
        x = Mathf.Clamp(x, -maxVerticalAngle, maxVerticalAngle);
    }
}**/
