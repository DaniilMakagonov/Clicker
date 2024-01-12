using TMPro;
using Core;
using UnityEngine;

namespace Game
{
  public class ResourceVisual : MonoBehaviour
  {
    [SerializeField] 
    private GameManager _gameManager;

    [SerializeField] 
    private GameResource _resource;

    [SerializeField] private TextMeshProUGUI _text;

    private void Start()
    {
      UpdateText(_resource);
      _gameManager.ResourceBank.OnResourceChanged += UpdateText;
    }

    private void UpdateText(GameResource resource)
    {
      if (_resource == resource)
      {
        _text.text = $"{resource.ToString()}: {_gameManager.ResourceBank.GetResource(resource)}";
      }
    }
  }
}