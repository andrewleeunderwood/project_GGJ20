using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{

    public GameObject brokenVersion;
    public GameObject goalVersion;
public AK.Wwise.Event MyEvent;


    // Start on collision with table
    void OnCollisionEnter()
    {
        
        Destroy(gameObject);
MyEvent.Post(gameObject);
        Instantiate(brokenVersion);
        Instantiate(goalVersion);
        //goalVersion.GetComponent<Renderer>().enabled = false;

        // foreach (Transform child in brokenVersion.transform) {

        //     var obj = new GameObject("fuck");

        //     // m.sharedMesh = 
        //     var r = obj.AddComponent<MeshRenderer>();

        //     var mfs = child.gameObject.GetComponent<MeshFilter>();
            
        //     var combined = new CombineInstance();
        //     combined.subMeshIndex = 0;
        //     combined.mesh = mfs.sharedMesh;
        //     combined.transform = mfs.transform.localToWorldMatrix;

        //     var mesh = new Mesh() { name = "Copy" };
        //     mesh.CombineMeshes(new CombineInstance[] { combined } );

        //     var m = obj.AddComponent<MeshFilter>();
        //     m.sharedMesh = mesh;

        //     foreach (var mat in child.gameObject.GetComponentInChildren<MeshRenderer>().sharedMaterials) {
        //         r.material = clearMaterial;
        //     }
        //     // obj.AddComponent<MeshCollider>();

        //     obj.transform.rotation = Quaternion.identity; //child.gameObject.transform.rotation;
        //     obj.transform.position = Vector3.zero; //child.gameObject.transform.position;
            
        //     // var dragger = child.gameObject.AddComponent<DragObject>();
        //     // dragger.parent = child.gameObject;
        //     // Debug.Log(dragger.parent);

        //     // obj.sharedMesh = child.sharedMesh;
        //     // obj.transform.position = child.gameObject.transform.position;

        // }

        // foreach (Transform child in brokenVersion.transform) {

        //     var obj = new GameObject();
        //     var m = obj.AddComponent<MeshFilter>();
        //     var r = obj.AddComponent<MeshRenderer>();
        //     foreach (var mat in child.gameObject.GetComponent<MeshRenderer>().sharedMaterials) {
        //         r.material = mat;
        //     }

        // }
            // obj.AddComponent<MeshCollider>();
            // obj.sharedMesh = child.sharedMesh;
            // obj.transform.position = child.gameObject.transform.position;


    }


}
