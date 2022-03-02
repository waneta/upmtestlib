using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace upmlib
{
    public class RotateMe2 : MonoBehaviour
    {
        public float angularVelocity = 10;
        void Update()
        {
            var rot = Quaternion.AngleAxis(angularVelocity * Time.deltaTime, Vector3.up);
            transform.localRotation = rot * transform.localRotation;
        }
    }
}
