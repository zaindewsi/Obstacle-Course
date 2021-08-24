using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
  [SerializeField] float x = 0;
  [SerializeField] float y = 2f;
  [SerializeField] float z = 0;

  void Update()
  {
    transform.Rotate(x, y, z);
  }
}
