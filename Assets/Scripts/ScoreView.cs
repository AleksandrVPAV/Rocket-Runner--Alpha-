using UnityEngine;
using TMPro;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreView;
    [SerializeField] private float _lerpSpeed;
    private Rocket _rocket;

    private void Awake()
    {
        _rocket = FindObjectOfType<Rocket>();
    }

    private void Update()
    {
        int targetScore = Mathf.RoundToInt(_rocket.transform.position.y);
        int currentScore = int.Parse(_scoreView.text);
        int newScore = Mathf.RoundToInt(Mathf.Lerp(currentScore, targetScore, _lerpSpeed));
        _scoreView.text = newScore.ToString();
    }
}
