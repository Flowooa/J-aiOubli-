using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next602to603 : MonoBehaviour

{
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("Phase 6-3");
    }
}