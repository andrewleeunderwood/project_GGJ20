using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class OnClicker : MonoBehaviour
{
    public GameObject original;

    void Start() {
        var fuck = gameObject.name.Substring(2);
        Debug.Log(fuck);
        original = GameObject.Find(fuck);
    }

    void OnMouseDown() {
        // Destroy(gameObject);
        gameObject.transform.position = original.transform.position;
        gameObject.transform.rotation = original.transform.rotation;
        Destroy(gameObject.GetComponent<Rigidbody>());
    }

}
