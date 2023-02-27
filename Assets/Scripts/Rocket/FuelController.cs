using UnityEngine;
using UnityEngine.UI;

public class FuelController : MonoBehaviour
{
    [SerializeField] private float _maxFuelAmount;
    [SerializeField] private float _fuelConsumptionRate;
    [SerializeField] private Slider _fuelSlider;

    private float _fuelLevel;

    private void Start()
    {
        _fuelLevel = _maxFuelAmount;
        _fuelSlider.maxValue = _maxFuelAmount;
        _fuelSlider.value = _maxFuelAmount;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Fuel fuel))
        {
            _fuelLevel += fuel.Collect();
        }
    }


    private void Update()
    {
        float fuelConsumed = _fuelConsumptionRate * Time.deltaTime;
        _fuelLevel = Mathf.Max(0f, _fuelLevel - fuelConsumed);

        _fuelSlider.value = _fuelLevel;
        if (_fuelLevel > _maxFuelAmount)
        {
            _fuelLevel = _maxFuelAmount;
        }
    }
}
