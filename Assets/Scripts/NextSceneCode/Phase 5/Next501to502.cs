using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next501to502 : MonoBehaviour

{
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("Phase 5-2");
    }
}
