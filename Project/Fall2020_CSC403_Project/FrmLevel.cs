using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;
    private DateTime timeBegin;

    public FrmLevel() {
      InitializeComponent();
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      Vector2 initPos = new Vector2(picPlayer.Location.X, picPlayer.Location.Y);
      player = new Player(initPos);
      timeBegin = DateTime.Now;
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      switch(e.KeyCode) {
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
      player.Move();
      picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
    }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
      TimeSpan span = DateTime.Now - timeBegin;
      string time = span.ToString(@"hh\:mm\:ss");
      lblInGameTime.Text = "Time: " + time.ToString();
    }
  }
}
