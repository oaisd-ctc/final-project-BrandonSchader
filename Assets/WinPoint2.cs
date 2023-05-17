using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPoint2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider Others)
    {
        if (Others.tag == "WinPoint")
        {
            SceneManager.LoadScene("Scene3");
            Debug.Log("touching");
        }
    }
}
