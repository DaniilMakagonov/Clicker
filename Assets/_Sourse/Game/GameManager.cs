using Core;
using UnityEngine;

namespace Game
{
  public class GameManager : MonoBehaviour
  {
    private readonly ResourceBank _resourceBank = new();
    public ResourceBank ResourceBank => _resourceBank;

    private void Awake()
    {
      _resourceBank.ChangeResource(GameResource.Humans, 10);
      _resourceBank.ChangeResource(GameResource.Food, 5);
      _resourceBank.ChangeResource(GameResource.Wood, 5);
    }
  }
}