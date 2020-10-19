using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;
    private DateTime timeBegin;
    private Enemy koolaid;
    private Character wall;

    public FrmLevel() {
      InitializeComponent();
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      Vector2 initPos;
      const int PADDING = 7;

      initPos = new Vector2(picPlayer.Location.X, picPlayer.Location.Y);
      player = new Player(initPos, CreateCollider(picPlayer, PADDING));

      initPos = new Vector2(picKoolAid.Location.X, picKoolAid.Location.Y);
      koolaid = new Enemy(initPos, CreateCollider(picKoolAid, PADDING));

      initPos = new Vector2(picWall.Location.X, picWall.Location.Y);
      wall = new Character(initPos, CreateCollider(picWall, PADDING));

      timeBegin = DateTime.Now;
    }

    private Collider CreateCollider(PictureBox pic, int padding) {
      Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
      return new Collider(rect);
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      player.ResetMoveSpeed();
    }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
      TimeSpan span = DateTime.Now - timeBegin;
      string time = span.ToString(@"hh\:mm\:ss");
      lblInGameTime.Text = "Time: " + time.ToString();
    }

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
      player.Move();
      if (player.Collider.Intersects(wall.Collider)) {
        player.MoveBack();
      }

      picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
    }

    private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
      switch (e.KeyCode) {
        case Keys.Left:
          player.GoLeft();
          break;

        case Keys.Right:
          player.GoRight();
          break;

        case Keys.Up:
          player.GoUp();
          break;

        case Keys.Down:
          player.GoDown();
          break;

        default:
          player.ResetMoveSpeed();
          break;
      }
    }
  }
}
