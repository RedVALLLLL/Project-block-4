using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Keypad : MonoBehaviour
{
    public string password = "2671";
    public GameObject hinge;
    public float rotationAmount = 45f;
    public float speed = 5f;

    private string userInput = "";
    private bool unlocked = false;
    private bool animating = false;
    private float targetRotation;

    private void Start()
    {
        userInput = "";
        targetRotation = hinge.transform.eulerAngles.y + rotationAmount;
    }
  
    public void ButtonClicked(string number)
    {
        userInput += number;
        Debug.Log(userInput);
        if (userInput.Length >= 4 && !unlocked)
        {
            if (userInput == password)
            {
                unlocked = true;
                animating = true;
                Debug.Log("Entry allowed");
                
            }
            else
            {
                Debug.Log("Entry Denied");
                userInput = "";
            }
            
        }
    }
    private void Update()
    {
        if (unlocked && animating){
           
            hinge.transform.rotation = Quaternion.Slerp(hinge.transform.rotation, Quaternion.Euler(0f, targetRotation, 0f), speed * Time.deltaTime);
            if(hinge.transform.eulerAngles.y == targetRotation){
               animating = false; 
            }
        }
    }
}
