using Domain;
using UnityEngine;
using Zenject;

namespace Application
{
    public class PlayerIdleState : IPlayerState
    {
        private readonly IPlayerComponent _player;

        [Inject]
        public PlayerIdleState(IPlayerComponent player)
        {
            _player = player;
        }

        public void Enter()
        {

        }

        public void Update()
        {
            // 移動の入力があればMoveStateに遷移
            if (_player.Input.GetMoveDir() != Vector2.zero)
            {
                _player.TransitionState(new PlayerWalkState(_player));
                return;
            }

            _player.Attack();
        }

        public void FixedUpdate()
        {
            _player.Move();
            _player.LookRotationCameraDirIdleState();
        }

        public void Exit()
        {

        }
    }
}
