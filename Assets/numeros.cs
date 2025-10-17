using TMPro;
using UnityEngine;

public class numeros : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform jogador;
    public TMP_Text contar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contar.text = jogador.position.z.ToString("0");
    }
}