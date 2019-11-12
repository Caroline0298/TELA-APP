using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour
{
    public static int id;
    

    public static void SalvaUsuario(string login, string senha, string nome, string sobrenome, string email) {
        PlayerPrefs.SetInt("usuarioId", PlayerPrefs.GetInt("usuarioId") + 1);
        UpdateId();
        PlayerPrefs.SetString("usuarioLogin" + id, login);
        PlayerPrefs.SetString("usuarioSenha" + id, senha);
        PlayerPrefs.SetString("usuarioNome" + id, nome);
        PlayerPrefs.SetString("usuarioSobrenome" + id, sobrenome);
        PlayerPrefs.SetString("usuarioEmail" + id, email);
        Debug.Log("Usuário Cadastrado:");
        Debug.Log("id: "+id);
        Debug.Log("Login: "+login);
        Debug.Log("Senha: " + senha);
        Debug.Log("Nome: " + nome);
        Debug.Log("Sobrenome: " + sobrenome);
        Debug.Log("Email: " + email);
    }

    public static void AutenticaUsuario(string login, string senha)
    {
        Debug.Log("Verificando dados...");
        UpdateId();
        for (int i = 0; i <= id; i++)
        {            
            if (login == PlayerPrefs.GetString("usuarioLogin" + i) && senha
                == PlayerPrefs.GetString("usuarioSenha" + i))
            {
                UIControllerScript.AutenticaOK();
                Debug.Log("Usuario Autenticado");
                break;
            }
            else
            {
                Debug.Log("Login ou senha inválidos");
            }
        }
    }

    public static void UpdateId() {
        id = PlayerPrefs.GetInt("usuarioId");
    }
}
