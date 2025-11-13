using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{
    private Button exitButton;

    private void Awake() {
        exitButton = GetComponent<Button>();
    }
    private void Start() {
        exitButton.onClick.AddListener(Exit);
    }
    private void OnDisable() {
        exitButton.onClick.RemoveListener(Exit);
    }
    private void Exit() {
        Debug.Log("Saliendo...");
        Application.Quit();
    }
}
