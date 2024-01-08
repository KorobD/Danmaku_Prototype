using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemy {
    public int HealthPoint { set; }
    public void TakeDamage(int damage);
    public void GiveBonus(string bonus);


}
