using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyesZoon : MonoBehaviour
{
    [SerializeField]
    private Enemy parent;

private void OnTriggerEnter(Collider other)
    {
        parent.CheckSight();
    }
}
