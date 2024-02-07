using UnityEngine;
using UnityEngine.UI;

namespace Mediator
{
    public class DefeatPanel : MonoBehaviour
    {
        [SerializeField] private GameObject _restartWindow;
        [SerializeField] private Button _restart;

        private DefeatMediator _mediator;

        public void Initialize(DefeatMediator mediator)
        {
            _mediator = mediator;
            _restartWindow.SetActive(false);
        }

        private void OnEnable()
        {
            _restart.onClick.AddListener(OnRestartClick);
        }

        private void OnDisable()
        {
            _restart.onClick.RemoveListener(OnRestartClick);
        }

        public void Show() => _restartWindow.SetActive(true);

        public void Hide() => _restartWindow.SetActive(false);

        private void OnRestartClick() => _mediator.RestartLevel();
    }
}