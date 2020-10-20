using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.code {
  public class Enemy : BattleCharacter {
    public Image Img { get; set; }
    public Color Color { get; set; }

    public Enemy(Vector2 initPos, Collider collider) : base(initPos, collider) {
    }
  }
}
