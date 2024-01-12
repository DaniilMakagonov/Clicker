using Core;
using UnityEngine;

namespace Game
{
  public class ProductionBuilding : MonoBehaviour
  {
    [SerializeField] 
    private GameManager _gameManager;
    [SerializeField] 
    private GameResource _resource;

    public void Increase()
    {
      _gameManager.ResourceBank.ChangeResource(_resource, 1);
    }
  }
}