using UnityEngine;

public class Stamina : MonoBehaviour
{
    private float _maxValue;
    private float _value;

    public bool IsRecovered => _value == _maxValue;

    public Stamina(float maxValue)
    {
        _maxValue = maxValue;
        _value = maxValue;
    }

    public void RecoverStamine(float amount)
    {
        if (_value + amount > _maxValue)
        {
            _value = _maxValue;
        }
        else
        {
            _value += amount;
        }
    }

    public bool TryUseStamine(float amount)
    {
        if (amount < _value)
        {
            _value -= amount;
            return true;
        }

        return false;
    }
}