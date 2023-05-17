using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPoint3 : MonoBehaviour
{
    private void OnTriggerEnter(Collider Others)
    {
        if (Others.tag == "WinPoint")
        {
            SceneManager.LoadScene("Scene1");
            Debug.Log("touching");
        }
    }
}
