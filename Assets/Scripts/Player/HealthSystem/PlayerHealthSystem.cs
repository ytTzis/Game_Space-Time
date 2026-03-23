using System;
using UnityEngine;

namespace UGG.Health
{
    public class PlayerHealthSystem : CharacterHealthSystemBase
    {
        [Header("Player HP")]
        [SerializeField] private float maxHealth = 100f;
        [SerializeField] private float currentHealth = 100f;

        public float MaxHealth => maxHealth;
        public float CurrentHealth => currentHealth;
        public float HealthNormalized => maxHealth <= 0f ? 0f : currentHealth / maxHealth;

        protected override void Awake()
        {
            base.Awake();
            currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);
        }

        public override void TakeDamager(float damager)
        {
            ApplyDamage(damager);
        }

        public override void TakeDamager(float damager, string hitAnimationName)
        {
            ApplyDamage(damager);
            PlayHitAnimation(hitAnimationName);
        }

        public override void TakeDamager(float damagar, string hitAnimationName, Transform attacker)
        {
            SetAttacker(attacker);
            ApplyDamage(damagar);
            PlayHitAnimation(hitAnimationName);
        }

        public void RestoreFullHealth()
        {
            currentHealth = maxHealth;
        }

        private void ApplyDamage(float damage)
        {
            if (damage <= 0f)
            {
                return;
            }

            currentHealth = Mathf.Clamp(currentHealth - damage, 0f, maxHealth);
        }

        private void PlayHitAnimation(string hitAnimationName)
        {
            if (string.IsNullOrWhiteSpace(hitAnimationName) || _animator == null)
            {
                return;
            }

            _animator.Play(hitAnimationName, 0, 0f);
        }
    }
}
