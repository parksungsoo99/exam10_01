using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(exam10_01))]
public class exam10_01Editor : Editor
{
    public override void OnInspectorGUI(){
        base.OnInspectorGUI();

        exam10_01 script = (exam10_01)target;

        if(GUILayout.Button("do matrix")){

            Matrix4x4 _mat = script.transform.localToWorldMatrix;
            script.matrixOut = _mat;

            Debug.Log("forward vector : "+ script.matrixOut.GetColumn(2));
            Debug.Log("up  vector : "+ script.matrixOut.GetColumn(1));

            Debug.Log("right Vector:"+Vector3.Cross(
                script.matrixOut.GetColumn(2),
               script.matrixOut.GetColumn(1)));

        }


        if(GUILayout.Button("apply Matrix")){
            Vector3 vPos = script.matrixOut.GetColumn(3);
            Vector3 vForward = script.matrixOut.GetColumn(2);
            Vector3 vUp = script.matrixOut.GetColumn(1);

            script.target1.transform.position = vPos;   // 위치
            script.target1.transform.rotation = Quaternion.LookRotation(
                vForward,vUp
                
            ); // 회전

        }
    }
}
