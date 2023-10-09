using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehaviorScriptZ : MonoBehaviour
{
    void Update()
    {
        float rotate = 360.0f * Time.deltaTime / 36.0f;

        this.transform.Rotate(0, 0, rotate);
    }
}
