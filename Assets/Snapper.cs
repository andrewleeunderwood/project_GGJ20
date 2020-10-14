using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snapper : MonoBehaviour
{
    public GameObject parent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDrag() {
        gameObject.transform.rotation = parent.transform.rotation;
        // gameObject.transform.pos
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
