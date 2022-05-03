using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousecursor : MonoBehaviour
{
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    // Start is called before the first frame update
    void OnMouseEnter()
    {
        Cursor.SetCursor(cursor, hotSpot, Vector2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
