using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObectHit : MonoBehaviour
{
  private void OnCollisionEnter(Collision other)
  {
    GetComponent<MeshRenderer>().material.color = Color.red;
  }
}
