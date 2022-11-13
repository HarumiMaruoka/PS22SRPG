using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ビルボードさせる
/// </summary>
public class Billboard : MonoBehaviour
{
    Camera _main;

    void Start()
    {
        _main = Camera.main;
    }

    void Update()
    {
        Vector3 target = new Vector3(_main.transform.position.x, 0, _main.transform.position.z);
        transform.LookAt(target);
    }
}
