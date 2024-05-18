using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trap_manager : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {          
            StartCoroutine(die());
        }
    }

    IEnumerator die()
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
