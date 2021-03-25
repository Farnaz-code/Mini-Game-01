using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacles : MonoBehaviour
{
    [SerializeField] float speed = 1f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.GetComponent<Player>() != null)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void Update()
    {
        transform.position += Time.deltaTime * speed * Vector3.left;
    }
}
