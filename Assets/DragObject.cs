using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour {
    private Vector3 mOffset;

    private float mZCoord;

    public GameObject parent;

    void OnMouseDown () {
        mZCoord = Camera.main.WorldToScreenPoint (gameObject.transform.position).z;

        // Store offset = gameobject world pos - mouse world pos
        Vector3 vec = GetMouseAsWorldPoint ();
        // vec.y = 0;

        mOffset = gameObject.transform.position - vec;
    }

    private Vector3 GetMouseAsWorldPoint () {
        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;

        // z coordinate of game object on screen
        mousePoint.z = mZCoord;

        // Convert it to world points
        return Camera.main.ScreenToWorldPoint (mousePoint);
    }

    void OnMouseDrag () {
        var p = GetMouseAsWorldPoint () + mOffset;
        p.y = transform.position.y;
        transform.position = p;
        transform.rotation = parent.transform.rotation;
    }
}
