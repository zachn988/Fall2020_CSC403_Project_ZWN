namespace Fall2020_CSC403_Project {
  partial class FrmLevel {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevel));
      this.lblInGameTime = new System.Windows.Forms.Label();
      this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
      this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
      this.picWall = new System.Windows.Forms.PictureBox();
      this.picKoolAid = new System.Windows.Forms.PictureBox();
      this.picPlayer = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.picWall)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picKoolAid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
      this.SuspendLayout();
      // 
      // lblInGameTime
      // 
      this.lblInGameTime.AutoSize = true;
      this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblInGameTime.ForeColor = System.Drawing.Color.White;
      this.lblInGameTime.Location = new System.Drawing.Point(12, 617);
      this.lblInGameTime.Name = "lblInGameTime";
      this.lblInGameTime.Size = new System.Drawing.Size(46, 18);
      this.lblInGameTime.TabIndex = 2;
      this.lblInGameTime.Text = "label1";
      // 
      // tmrUpdateInGameTime
      // 
      this.tmrUpdateInGameTime.Enabled = true;
      this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
      // 
      // tmrPlayerMove
      // 
      this.tmrPlayerMove.Enabled = true;
      this.tmrPlayerMove.Interval = 10;
      this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
      // 
      // picWall
      // 
      this.picWall.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
      this.picWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall.Location = new System.Drawing.Point(90, 261);
      this.picWall.Name = "picWall";
      this.picWall.Size = new System.Drawing.Size(445, 103);
      this.picWall.TabIndex = 3;
      this.picWall.TabStop = false;
      // 
      // picKoolAid
      // 
      this.picKoolAid.BackColor = System.Drawing.Color.Transparent;
      this.picKoolAid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picKoolAid.BackgroundImage")));
      this.picKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picKoolAid.Location = new System.Drawing.Point(688, 12);
      this.picKoolAid.Name = "picKoolAid";
      this.picKoolAid.Size = new System.Drawing.Size(238, 254);
      this.picKoolAid.TabIndex = 1;
      this.picKoolAid.TabStop = false;
      // 
      // picPlayer
      // 
      this.picPlayer.BackColor = System.Drawing.Color.Transparent;
      this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
      this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picPlayer.Location = new System.Drawing.Point(56, 428);
      this.picPlayer.Name = "picPlayer";
      this.picPlayer.Size = new System.Drawing.Size(87, 157);
      this.picPlayer.TabIndex = 0;
      this.picPlayer.TabStop = false;
      // 
      // FrmLevel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.DimGray;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(938, 644);
      this.Controls.Add(this.picWall);
      this.Controls.Add(this.lblInGameTime);
      this.Controls.Add(this.picKoolAid);
      this.Controls.Add(this.picPlayer);
      this.DoubleBuffered = true;
      this.Name = "FrmLevel";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.FrmLevel_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
      ((System.ComponentModel.ISupportInitialize)(this.picWall)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picKoolAid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picPlayer;
    private System.Windows.Forms.PictureBox picKoolAid;
    private System.Windows.Forms.Label lblInGameTime;
    private System.Windows.Forms.Timer tmrUpdateInGameTime;
    private System.Windows.Forms.Timer tmrPlayerMove;
    private System.Windows.Forms.PictureBox picWall;
  }
}

