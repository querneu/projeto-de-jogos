using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Olá, bem-vindo ao adivinhador de números");
        Debug.Log("Esolha um número e não me diga qual é, entre "+min+" e "+max+": ");
        Debug.Log("Me diga se seu número é maior ou menor do que minha tentativa!");
        Debug.Log("Botão 'UP' para maior");
        Debug.Log("Botão 'DOWN' para menor");
        Debug.Log("Botão 'ENTER' para correto");
        
    }

    // Update is called once per frame
    void Update()
    {
        int guess = min;
        if (Input.GetKeyDown(KeyCode.UpArrow))
            Debug.Log("Botão UP pressionado!");
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            Debug.Log("Botão DOWN pressionado!");
        else if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("Botão ENTER pressionado!");
    }
}
