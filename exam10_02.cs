using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exam10_02 : MonoBehaviour
{
    public GameObject target;

    public Vector3 targetPos;
    public Vector3 targetAngle; // 시험 가능성 있습

    public Matrix4x4 matrixResult;
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
        Gizmos.DrawRay(target.transform.position, target.transform.forward * 5);
    }
}
