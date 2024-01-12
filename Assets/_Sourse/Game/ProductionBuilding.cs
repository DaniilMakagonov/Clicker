using System;
using System.Collections;
using Core;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
  public class ProductionBuilding : MonoBehaviour
  {
    [SerializeField] 
    private GameManager _gameManager;
    [SerializeField] 
    private GameResource _resource;

    [SerializeField]
    private int _productionTime;

    private Button _button;

    private void Start()
    {
      _button = gameObject.GetComponent<Button>();
    }


    public void Increase()
    {
      StartCoroutine(Increasing());
      Debug.Log("Button pushed");
    }

    private IEnumerator Increasing()
    {
      _button.interactable = false;
      for (int i = 0; i < _productionTime; i++)
      {
        _gameManager.ResourceBank.ChangeResource(_resource, 1);
        yield return new WaitForSeconds(1);
      }
      _button.interactable = true;
    }
  }
}