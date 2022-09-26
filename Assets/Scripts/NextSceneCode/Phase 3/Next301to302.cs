using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next301to302 : MonoBehaviour

{
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("Round 3-2");
    }
}
