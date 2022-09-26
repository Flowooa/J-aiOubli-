using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Next1to2 : MonoBehaviour
{
 private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("Round 2");
    }
}
