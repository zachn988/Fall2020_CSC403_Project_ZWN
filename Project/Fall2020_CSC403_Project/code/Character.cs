using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Character {
    private const int GO_INC = 30;

    public Vector2 MoveSpeed { get; private set; }
    public Vector2 Position { get; private set; }

    public Character(Vector2 initPos) {
      Position = initPos;
    }

    public void Move() {
      Position = new Vector2(Position.x + MoveSpeed.x, Position.y + MoveSpeed.y);
    }

    public void GoLeft() {
      MoveSpeed = new Vector2(-GO_INC, 0);
    }
    public void GoRight() {
      MoveSpeed = new Vector2(+GO_INC, 0);
    }
    public void GoUp() {
      MoveSpeed = new Vector2(0, -GO_INC);
    }
    public void GoDown() {
      MoveSpeed = new Vector2(0, +GO_INC);
    }

    public void ResetMoveSpeed() {
      MoveSpeed = new Vector2(0, 0);
    }
  }
}
