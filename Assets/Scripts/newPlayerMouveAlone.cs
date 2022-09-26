using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class newPlayerMouveAlone : MonoBehaviour
{
  
    [SerializeField] private float sped = 10f;
    private Rigidbody rbz;
    private Vector2 Moveput;

    private void Awake()
    {
        rbz = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rbz.velocity = Moveput * sped;
    }
    public void depacement(InputAction.CallbackContext cnt)
    {
        Moveput = cnt.ReadValue<Vector2>();
    }
}
