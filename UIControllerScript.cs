using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIControllerScript : MonoBehaviour
{
    public GameObject loginPanel, cadastroPanel;
    public InputField lpLogin, lpSenha;
    public InputField cadLogin, cadSenha, cadNome, cadSobrenome, cadEmail;
    public int contador, vida;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void AutenticaOK()
    {
        SceneManager.LoadScene("inicio");
    }

    public void Login()
    {

        DataController.AutenticaUsuario(lpLogin.text, lpSenha.text);
    }

    public void Cadastrar() {
        DataController.SalvaUsuario(cadLogin.text, cadSenha.text, cadNome.text, cadSobrenome.text, cadEmail.text);
        HideCadastro();
    }

    public void Exit() {
        Application.Quit();
        Debug.Log("Saiu do Aplicativo");
    }

    public void ShowPanel() {
        loginPanel.SetActive(true);
    }
    public void HidePanel()
    {
        loginPanel.SetActive(false);
    }
    public void ShowCadastro()
    {
        cadastroPanel.SetActive(true);
    }
    public void HideCadastro()
    {
        cadastroPanel.SetActive(false);
    }
}
