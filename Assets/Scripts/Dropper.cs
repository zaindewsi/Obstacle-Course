using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
  MeshRenderer newRenderer;
  Rigidbody newRigidbody;
  [SerializeField] float timeToWait = 3f;

  // Start is called before the first frame update
  void Start()
  {
    newRenderer = GetComponent<MeshRenderer>();
    newRigidbody = GetComponent<Rigidbody>();

    newRenderer.enabled = false;
    newRigidbody.useGravity = false;

  }

  // Update is called once per frame
  void Update()
  {
    if (Time.time > timeToWait)
    {
      newRenderer.enabled = true;
      newRigidbody.useGravity = true;

    }
  }
}
