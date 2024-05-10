    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exam10_01 : MonoBehaviour
{
    public GameObject target1;
    public Matrix4x4 matrixOut;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDrawGizmos(){
        Gizmos.color = Color.red;
        Gizmos.DrawRay(target1.transform.position,target1.transform.forward);
    }
}
