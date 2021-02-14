
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addBtn = new System.Windows.Forms.RadioButton();
            this.subtractBtn = new System.Windows.Forms.RadioButton();
            this.multiplyBtn = new System.Windows.Forms.RadioButton();
            this.divideBtn = new System.Windows.Forms.RadioButton();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.colorBtn = new System.Windows.Forms.Button();
            this.btnColorPicker = new System.Windows.Forms.Button();
            this.helpMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItems = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forLoopBtn = new System.Windows.Forms.Button();
            this.whileLoopBtn = new System.Windows.Forms.Button();
            this.memoryBtn = new System.Windows.Forms.Button();
            this.mLabel = new System.Windows.Forms.Label();
            this.memoryDisplay = new System.Windows.Forms.Label();
            this.memoryAddBtn = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.memoryBox = new System.Windows.Forms.PictureBox();
            this.helpMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoryBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.AutoSize = true;
            this.addBtn.Location = new System.Drawing.Point(267, 125);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(31, 17);
            this.addBtn.TabIndex = 0;
            this.addBtn.TabStop = true;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // subtractBtn
            // 
            this.subtractBtn.AutoSize = true;
            this.subtractBtn.Location = new System.Drawing.Point(267, 156);
            this.subtractBtn.Name = "subtractBtn";
            this.subtractBtn.Size = new System.Drawing.Size(28, 17);
            this.subtractBtn.TabIndex = 1;
            this.subtractBtn.TabStop = true;
            this.subtractBtn.Text = "-";
            this.subtractBtn.UseVisualStyleBackColor = true;
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.AutoSize = true;
            this.multiplyBtn.Location = new System.Drawing.Point(266, 189);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(29, 17);
            this.multiplyBtn.TabIndex = 2;
            this.multiplyBtn.TabStop = true;
            this.multiplyBtn.Text = "*";
            this.multiplyBtn.UseVisualStyleBackColor = true;
            // 
            // divideBtn
            // 
            this.divideBtn.AutoSize = true;
            this.divideBtn.Location = new System.Drawing.Point(265, 222);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(30, 17);
            this.divideBtn.TabIndex = 3;
            this.divideBtn.TabStop = true;
            this.divideBtn.Text = "/";
            this.divideBtn.UseVisualStyleBackColor = true;
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(47, 122);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(184, 20);
            this.input1.TabIndex = 4;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(337, 122);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(180, 20);
            this.input2.TabIndex = 5;
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(565, 122);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(168, 20);
            this.answerBox.TabIndex = 6;
            // 
            // calculateBtn
            // 
            this.calculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateBtn.Location = new System.Drawing.Point(102, 330);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(149, 43);
            this.calculateBtn.TabIndex = 7;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Location = new System.Drawing.Point(321, 330);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(129, 43);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Location = new System.Drawing.Point(518, 330);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(117, 43);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // colorPicker
            // 
            this.colorPicker.Color = System.Drawing.Color.DarkGray;
            // 
            // colorBtn
            // 
            this.colorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colorBtn.Location = new System.Drawing.Point(565, 27);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(140, 23);
            this.colorBtn.TabIndex = 10;
            this.colorBtn.Text = "Background color picker";
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // btnColorPicker
            // 
            this.btnColorPicker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColorPicker.Location = new System.Drawing.Point(565, 56);
            this.btnColorPicker.Name = "btnColorPicker";
            this.btnColorPicker.Size = new System.Drawing.Size(140, 23);
            this.btnColorPicker.TabIndex = 11;
            this.btnColorPicker.Text = "Button color picker";
            this.btnColorPicker.UseVisualStyleBackColor = true;
            this.btnColorPicker.Click += new System.EventHandler(this.btnColorPicker_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.helpMenu.Size = new System.Drawing.Size(108, 26);
            this.helpMenu.Text = "Menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem1.Text = "About";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItems});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItems
            // 
            this.menuItems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.backgroundColorToolStripMenuItem,
            this.buttonColorToolStripMenuItem,
            this.calculateToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuItems.Name = "menuItems";
            this.menuItems.Size = new System.Drawing.Size(37, 20);
            this.menuItems.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // buttonColorToolStripMenuItem
            // 
            this.buttonColorToolStripMenuItem.Name = "buttonColorToolStripMenuItem";
            this.buttonColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.buttonColorToolStripMenuItem.Text = "Button Color";
            this.buttonColorToolStripMenuItem.Click += new System.EventHandler(this.buttonColorToolStripMenuItem_Click);
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // forLoopBtn
            // 
            this.forLoopBtn.Location = new System.Drawing.Point(63, 27);
            this.forLoopBtn.Name = "forLoopBtn";
            this.forLoopBtn.Size = new System.Drawing.Size(97, 24);
            this.forLoopBtn.TabIndex = 14;
            this.forLoopBtn.Text = "For Loop";
            this.forLoopBtn.UseVisualStyleBackColor = true;
            this.forLoopBtn.Click += new System.EventHandler(this.forLoopBtn_Click);
            // 
            // whileLoopBtn
            // 
            this.whileLoopBtn.Location = new System.Drawing.Point(180, 26);
            this.whileLoopBtn.Name = "whileLoopBtn";
            this.whileLoopBtn.Size = new System.Drawing.Size(129, 24);
            this.whileLoopBtn.TabIndex = 15;
            this.whileLoopBtn.Text = "While Loop";
            this.whileLoopBtn.UseVisualStyleBackColor = true;
            this.whileLoopBtn.Click += new System.EventHandler(this.whileLoopBtn_Click);
            // 
            // memoryBtn
            // 
            this.memoryBtn.Location = new System.Drawing.Point(321, 26);
            this.memoryBtn.Name = "memoryBtn";
            this.memoryBtn.Size = new System.Drawing.Size(117, 24);
            this.memoryBtn.TabIndex = 16;
            this.memoryBtn.Text = "M";
            this.memoryBtn.UseVisualStyleBackColor = true;
            this.memoryBtn.Click += new System.EventHandler(this.memoryBtn_Click);
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(658, 389);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(0, 13);
            this.mLabel.TabIndex = 17;
            // 
            // memoryDisplay
            // 
            this.memoryDisplay.AutoSize = true;
            this.memoryDisplay.Location = new System.Drawing.Point(470, 38);
            this.memoryDisplay.Name = "memoryDisplay";
            this.memoryDisplay.Size = new System.Drawing.Size(0, 13);
            this.memoryDisplay.TabIndex = 18;
            // 
            // memoryAddBtn
            // 
            this.memoryAddBtn.Location = new System.Drawing.Point(321, 55);
            this.memoryAddBtn.Name = "memoryAddBtn";
            this.memoryAddBtn.Size = new System.Drawing.Size(117, 24);
            this.memoryAddBtn.TabIndex = 19;
            this.memoryAddBtn.Text = "M+";
            this.memoryAddBtn.UseVisualStyleBackColor = true;
            this.memoryAddBtn.Click += new System.EventHandler(this.memoryAddBtn_Click);
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.LightGray;
            // 
            // memoryBox
            // 
            this.memoryBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.memoryBox.Location = new System.Drawing.Point(444, 38);
            this.memoryBox.Name = "memoryBox";
            this.memoryBox.Size = new System.Drawing.Size(115, 41);
            this.memoryBox.TabIndex = 20;
            this.memoryBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.memoryBox);
            this.Controls.Add(this.memoryAddBtn);
            this.Controls.Add(this.memoryDisplay);
            this.Controls.Add(this.mLabel);
            this.Controls.Add(this.memoryBtn);
            this.Controls.Add(this.whileLoopBtn);
            this.Controls.Add(this.forLoopBtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnColorPicker);
            this.Controls.Add(this.colorBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.divideBtn);
            this.Controls.Add(this.multiplyBtn);
            this.Controls.Add(this.subtractBtn);
            this.Controls.Add(this.addBtn);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.helpMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoryBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton addBtn;
        private System.Windows.Forms.RadioButton subtractBtn;
        private System.Windows.Forms.RadioButton multiplyBtn;
        private System.Windows.Forms.RadioButton divideBtn;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.Button btnColorPicker;
        private System.Windows.Forms.ContextMenuStrip helpMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItems;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button forLoopBtn;
        private System.Windows.Forms.Button whileLoopBtn;
        private System.Windows.Forms.Button memoryBtn;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Label memoryDisplay;
        private System.Windows.Forms.Button memoryAddBtn;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox memoryBox;
    }
}

