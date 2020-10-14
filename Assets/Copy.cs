using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in gameObject.transform) {

            var obj = new GameObject("fuck");

            // m.sharedMesh = 
            var r = obj.AddComponent<MeshRenderer>();

            var mfs = child.gameObject.GetComponent<MeshFilter>();
            
            var combined = new CombineInstance();
            combined.subMeshIndex = 0;
            combined.mesh = mfs.sharedMesh;
            combined.transform = mfs.transform.localToWorldMatrix;

            var mesh = new Mesh() { name = "Copy" };
            mesh.CombineMeshes(new CombineInstance[] { combined } );

            var m = obj.AddComponent<MeshFilter>();
            m.sharedMesh = mesh;

            foreach (var mat in child.gameObject.GetComponentInChildren<MeshRenderer>().sharedMaterials) {
                r.material = mat;
            }
            obj.AddComponent<MeshCollider>();
            obj.transform.rotation = Quaternion.identity; //child.gameObject.transform.rotation;
            obj.transform.position = Vector3.zero; //child.gameObject.transform.position;
            
            Debug.Log(obj);

            // obj.sharedMesh = child.sharedMesh;
            // obj.transform.position = child.gameObject.transform.position;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
