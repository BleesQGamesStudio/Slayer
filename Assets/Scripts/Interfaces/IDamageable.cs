using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable<T>
{
    void TakeDamage(T amount);
    void Heal(T amount);
    void Kill();
}
