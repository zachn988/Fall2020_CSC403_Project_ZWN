using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class BattleCharacter : Character {
    private int health;
    private int maxHealth;
    private int strength;

    public BattleCharacter(Vector2 initPos) : base(initPos) {
      maxHealth = 10;
      strength = 5;
      health = maxHealth;
    }
  }
}
