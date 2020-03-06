using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startMenu : MonoBehaviour
{
    public GameObject menu;
    //public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        //animator = GetComponent<Animator>();
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        Time.timeScale = 1;
        //menu.SetActive(false);
        //animator.SetTrigger("PlayButton");
        menu.SetActive(false);
        


    }

    public void Salir()
    {
        Application.Quit();
    }

    

}
