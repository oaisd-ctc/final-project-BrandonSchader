using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider Others)
    {
        if (Others.tag == "WinPoint")
        {
            SceneManager.LoadScene("Scene2");
            Debug.Log("touching");
        }
    }
}
