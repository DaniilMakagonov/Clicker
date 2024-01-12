using System.Collections.Generic;

namespace Core
{
  public class ResourceBank
  {
    private readonly Dictionary<GameResource, int> _resourceBank = new()
    {
      { GameResource.Humans, 0},
      { GameResource.Food, 0},
      { GameResource.Wood, 0},
      { GameResource.Stone, 0},
      { GameResource.Gold, 0}
    };

    public event System.Action<GameResource> OnResourceChanged;

    public int GetResource(GameResource resource)
    {
      return _resourceBank[resource];
    }

    public void ChangeResource(GameResource resource, int value)
    {
      _resourceBank[resource] += value;
      OnResourceChanged?.Invoke(resource);
    }
  }
}