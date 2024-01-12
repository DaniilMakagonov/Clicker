using System;
using System.Collections;
using Core;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
  public class ProductionBuilding : MonoBehaviour
  {
    private GameManager _gameManager;
    private GameResource _resource;
    
    [SerializeField] 
    private ResourceVisual _resourceVisual;

    private const int PRODUCTION_TIME = 60;
    
    [SerializeField]
    private GameObject _sliderObject;

    private Button _button;
    private Slider _slider;
    

    private void Start()
    {
      _button = gameObject.GetComponent<Button>();
      _gameManager = _resourceVisual.GameManager;
      _resource = _resourceVisual.Resource;
      _slider = _sliderObject.GetComponent<Slider>();
      _slider.interactable = false;
      _slider.value = 0;
      _sliderObject.SetActive(false);
      
    }


    public void Increase()
    {
      StartCoroutine(Increasing());
      Debug.Log("Button pushed");
    }

    private IEnumerator Increasing()
    {
      _button.interactable = false;
      _sliderObject.SetActive(true);
      for (int i = 0; i < PRODUCTION_TIME; i++)
      {
        _slider.value = (i + 1f) / PRODUCTION_TIME;
        _gameManager.ResourceBank.ChangeResource(_resource, 1);
        yield return new WaitForSeconds(1);
      }
      
      _button.interactable = true;
      _sliderObject.SetActive(false);
    }
  }
}