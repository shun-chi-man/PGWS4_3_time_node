using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehaviorScriptX : MonoBehaviour
{

    void Update()
    {
        float rotate = 360.0f * Time.deltaTime / 24.0f;

        this.transform.Rotate(rotate, 0, 0);
    }
}
