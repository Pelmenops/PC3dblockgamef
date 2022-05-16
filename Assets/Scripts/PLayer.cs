using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLayer : MonoBehaviour
{
    [SerializeField] KeyCode keyOne;
    [SerializeField] KeyCode keyTwo;
    [SerializeField] Vector3 MoveDirection;

    private void FixedUpdate() {
        if(Input.GetKey(keyOne)){GetComponent<Rigidbody>().velocity += MoveDirection;}
        if(Input.GetKey(keyTwo)){GetComponent<Rigidbody>().velocity -= MoveDirection;}
        if(Input.GetKey(KeyCode.R)){SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);}
        if(Input.GetKey(KeyCode.N)){SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);}
        if(Input.GetKey(KeyCode.P) && SceneManager.GetActiveScene().buildIndex !=0){SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);}

    }
    

    private void OnTriggerEnter(Collider other){
        if(this.CompareTag("Player") && other.CompareTag("Finish")){SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);}
    }
    
}
