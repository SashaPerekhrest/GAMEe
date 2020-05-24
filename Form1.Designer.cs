namespace game
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.obstacle3 = new System.Windows.Forms.PictureBox();
            this.icon = new System.Windows.Forms.PictureBox();
            this.bonus = new System.Windows.Forms.PictureBox();
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.trex = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreText.Location = new System.Drawing.Point(13, 13);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(119, 29);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score - 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameEvent);
            // 
            // obstacle3
            // 
            this.obstacle3.BackColor = System.Drawing.Color.White;
            this.obstacle3.Image = global::game.Properties.Resources.bird1;
            this.obstacle3.Location = new System.Drawing.Point(573, 259);
            this.obstacle3.Name = "obstacle3";
            this.obstacle3.Size = new System.Drawing.Size(36, 28);
            this.obstacle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle3.TabIndex = 7;
            this.obstacle3.TabStop = false;
            this.obstacle3.Tag = "obstacle";
            // 
            // icon
            // 
            this.icon.Image = global::game.Properties.Resources.white;
            this.icon.Location = new System.Drawing.Point(18, 45);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(45, 50);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 6;
            this.icon.TabStop = false;
            // 
            // bonus
            // 
            this.bonus.Image = global::game.Properties.Resources.pixel_shield_2021369;
            this.bonus.Location = new System.Drawing.Point(573, 320);
            this.bonus.Name = "bonus";
            this.bonus.Size = new System.Drawing.Size(31, 35);
            this.bonus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bonus.TabIndex = 5;
            this.bonus.TabStop = false;
            this.bonus.Tag = "bonus";
            // 
            // obstacle1
            // 
            this.obstacle1.BackColor = System.Drawing.Color.White;
            this.obstacle1.Image = global::game.Properties.Resources.obstacle_1;
            this.obstacle1.Location = new System.Drawing.Point(40, 405);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(23, 46);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle1.TabIndex = 3;
            this.obstacle1.TabStop = false;
            this.obstacle1.Tag = "obstacle";
            // 
            // obstacle2
            // 
            this.obstacle2.BackColor = System.Drawing.Color.White;
            this.obstacle2.Image = global::game.Properties.Resources.obstacle_2;
            this.obstacle2.Location = new System.Drawing.Point(330, 400);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(48, 51);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle2.TabIndex = 2;
            this.obstacle2.TabStop = false;
            this.obstacle2.Tag = "obstacle";
            // 
            // trex
            // 
            this.trex.BackColor = System.Drawing.Color.White;
            this.trex.Image = global::game.Properties.Resources.running;
            this.trex.Location = new System.Drawing.Point(131, 385);
            this.trex.Name = "trex";
            this.trex.Size = new System.Drawing.Size(44, 60);
            this.trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trex.TabIndex = 1;
            this.trex.TabStop = false;
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Black;
            this.floor.Location = new System.Drawing.Point(-12, 452);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(652, 50);
            this.floor.TabIndex = 0;
            this.floor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 485);
            this.Controls.Add(this.obstacle3);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.bonus);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.trex);
            this.Controls.Add(this.floor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.gameEvent);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.obstacle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox trex;
        private System.Windows.Forms.PictureBox obstacle2;
        private System.Windows.Forms.PictureBox obstacle1;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox bonus;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.PictureBox obstacle3;
    }
}

