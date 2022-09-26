using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next3to201 : MonoBehaviour

{
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("Round 2-1");
    }
}
