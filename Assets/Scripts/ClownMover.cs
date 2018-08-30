using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 小丑移动组件
/// </summary>
[RequireComponent(typeof(Animator))]
public class ClownMover : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void Move(Vector3 velocity)
    {
        transform.Translate(velocity * Time.deltaTime, Space.World);
    }

}
