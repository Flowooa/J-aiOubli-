using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next603toEnd : MonoBehaviour

{
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("End");
    }
}