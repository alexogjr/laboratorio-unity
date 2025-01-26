using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // nem rela que n�o tem o que mexer
        animator = GetComponent<Animator>();
        
        animator.SetBool("correr", false);
        animator.SetBool("dancar", false);
        animator.SetBool("parado", true);
    }

    // rotacao com parm
    void Rotacao(float rotacao)
    {
        transform.Rotate(0, rotacao * Time.deltaTime, 0, Space.Self);
    }

    void Update()
    {

        // uma velocidade daora � 5f, mas curti mais 10f
        float velocidade = 10f;

        if (Input.GetKey(KeyCode.W))
        {

            // vai pra frente
            transform.Translate(Vector3.forward * Time.deltaTime * velocidade, Space.Self);
            Rotacao(0);

            // for�ando os bools a n�o ativarem
            animator.SetBool("parado", false);
            animator.SetBool("dancar", false);
            animator.SetBool("correr", true);
        }

        else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            // vai pra esquerda
            transform.Translate(Vector3.left * Time.deltaTime * velocidade, Space.Self);
            Rotacao(90);
        }
        
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            // vai pra tr�s
            transform.Translate(Vector3.back * Time.deltaTime * velocidade, Space.Self);
            Rotacao(-180);
        }
        
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            // vai pra tras e pra direita juntos
            transform.Translate(Vector3.back * Time.deltaTime * velocidade, Space.Self);
            Rotacao(180);
        }
        
        else if (Input.GetKey(KeyCode.S))
        {
            // vai pra tras e vira bruscamente
            transform.Translate(Vector3.back * Time.deltaTime * velocidade, Space.Self);
            Rotacao(180);

        }
        else
        {
            // ele ficava bugando, ent�o for�o ele a desativar a anima��o quando nada estiver acontecendo (ele fica no param PARADO)
            animator.SetBool("correr", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            // vai pra direita e rotaciona
            Debug.Log("Tecla D foi pressionada!");
            transform.Translate(Vector3.right * Time.deltaTime * velocidade, Space.Self);
            Rotacao(90);
        }
        if (Input.GetKey(KeyCode.A))
        {
            // vai pra esquerda e rotaciona
            transform.Translate(Vector3.left * Time.deltaTime * velocidade, Space.Self);
            Rotacao(-90);
        }

        if (Input.GetKey(KeyCode.F)) // -> NO SCRIPT TROCADOR.CS adicionei um input.getkey para a altera��o de c�meras, e � feita assim que a keycode.F � ativa. d� uma olhada l�
        {
            // ele... ele dan�a. �, � s�rio
            Rotacao(0);
            animator.SetBool("dancar", true);
        } else
        {
            // mais uma vez tendo certeza de que tudo vai fluir
            animator.SetBool("dancar", false);
        }
    }
}
