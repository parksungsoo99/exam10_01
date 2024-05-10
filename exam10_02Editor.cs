using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(exam10_02))]
public class exam10_02Editor : Editor
{
   public override void OnInspectorGUI(){
        base.OnInspectorGUI();
        exam10_02 script = (exam10_02)target;

        if(GUILayout.Button("make transfoem")){
            Vector3 _pos = script.targetPos;
            Vector3 _rot = script.targetAngle;

            Quaternion _quat = Quaternion.Euler(_rot);

            Matrix4x4 matrix = Matrix4x4.TRS(_pos, _quat, Vector3.one);
            
            script.matrixResult = matrix;

            script.target.transform.position = matrix.GetColumn(3);
            script.target.transform.rotation = Quaternion.LookRotation(
                matrix.GetColumn(2),
                matrix.GetColumn(1)
            );

        }
   }
}
