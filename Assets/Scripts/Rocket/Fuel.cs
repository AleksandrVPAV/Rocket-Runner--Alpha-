using UnityEngine;
using TMPro;

public class Fuel : Obstacle
{
    [SerializeField] private TMP_Text _amounyView;
    private int _amount;

    private void Start()
    {
        _amount = Random.Range(1, 45);
        _amounyView.text = _amount.ToString();
    }

    public int Collect()
    {
        Destroy(gameObject);
        return _amount;
    }
}
