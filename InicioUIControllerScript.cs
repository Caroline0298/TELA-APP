using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InicioUIControllerScript : MonoBehaviour
{
    public InputField inpt_name, inpt_surname, inpt_login, inpt_senha, inpt_email;
    
    // Start is called before the first frame update
    void Start()
    {
        DataController.id = 1;
        UpdateUsuario();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateUsuario()
    {
        inpt_name.text = PlayerPrefs.GetString("usuarioNome"+DataController.id);
        inpt_surname.text = PlayerPrefs.GetString("usuarioSobrenome" + DataController.id);
        inpt_login.text = PlayerPrefs.GetString("usuarioLogin" + DataController.id);
        inpt_senha.text = PlayerPrefs.GetString("usuarioSenha" + DataController.id);
        inpt_email.text = PlayerPrefs.GetString("usuarioEmail" + DataController.id);
    }

    public void SalvaUsuario() {
        PlayerPrefs.SetString("usuarioNome" + DataController.id, inpt_name.text);
        PlayerPrefs.SetString("usuarioSobrenome" + DataController.id, inpt_surname.text);
        PlayerPrefs.SetString("usuarioLogin" + DataController.id, inpt_login.text);
        PlayerPrefs.SetString("usuarioSenha" + DataController.id, inpt_senha.text);
        PlayerPrefs.SetString("usuarioEmail" + DataController.id, inpt_email.text);
    }

    public void DeleteUsuario()
    {
        for(int i = DataController.id; i < PlayerPrefs.GetInt("usuarioId"); i++)
        {
            PlayerPrefs.SetString("usuarioNome" + i.ToString(), PlayerPrefs.GetString("usuarioNome" + (i + 1).ToString()));
            PlayerPrefs.SetString("usuarioSobrenome" + i.ToString(), PlayerPrefs.GetString("usuarioSobrenome" + (i + 1).ToString()));
            PlayerPrefs.SetString("usuarioLogin" + i.ToString(), PlayerPrefs.GetString("usuarioLogin" + (i + 1).ToString()));
            PlayerPrefs.SetString("usuarioSenha" + i.ToString(), PlayerPrefs.GetString("usuarioSenha" + (i + 1).ToString()));
            PlayerPrefs.SetString("usuarioEmail" + i.ToString(), PlayerPrefs.GetString("usuarioEmail" + (i+1).ToString()));
            
        }
        PlayerPrefs.SetInt("usuarioId", PlayerPrefs.GetInt("usuarioId") - 1);
        UpdateUsuario();
    }

    public void NextId() {
        if(DataController.id < PlayerPrefs.GetInt("usuarioId"))
        {
            DataController.id = DataController.id + 1;
            UpdateUsuario();
        }
    }
    public void PrevId()
    {
        if (DataController.id > 1)
        {
            DataController.id = DataController.id - 1;
            UpdateUsuario();
        }
    }
}
