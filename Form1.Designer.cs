namespace nov16_04_01
{
    partial class Jugador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxPosicion = new GroupBox();
            radioButtonBateador = new RadioButton();
            radioButtonJugador = new RadioButton();
            radioButtonPitcher = new RadioButton();
            buttonCapturar = new Button();
            buttonMostrar = new Button();
            buttonSalir = new Button();
            groupBoxDatos = new GroupBox();
            txtErrores = new TextBox();
            txtPonches = new TextBox();
            txtNombre = new TextBox();
            txtNumUniforme = new TextBox();
            numHits = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMuestra = new TextBox();
            label6 = new Label();
            groupBoxPosicion.SuspendLayout();
            groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHits).BeginInit();
            SuspendLayout();
            // 
            // groupBoxPosicion
            // 
            groupBoxPosicion.Controls.Add(radioButtonBateador);
            groupBoxPosicion.Controls.Add(radioButtonJugador);
            groupBoxPosicion.Controls.Add(radioButtonPitcher);
            groupBoxPosicion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxPosicion.ForeColor = SystemColors.ButtonHighlight;
            groupBoxPosicion.Location = new Point(87, 45);
            groupBoxPosicion.Name = "groupBoxPosicion";
            groupBoxPosicion.Size = new Size(215, 117);
            groupBoxPosicion.TabIndex = 0;
            groupBoxPosicion.TabStop = false;
            groupBoxPosicion.Text = "POSICION DEL JUGADOR";
            // 
            // radioButtonBateador
            // 
            radioButtonBateador.AutoSize = true;
            radioButtonBateador.Location = new Point(19, 79);
            radioButtonBateador.Name = "radioButtonBateador";
            radioButtonBateador.Size = new Size(92, 24);
            radioButtonBateador.TabIndex = 2;
            radioButtonBateador.TabStop = true;
            radioButtonBateador.Text = "Bateador";
            radioButtonBateador.UseVisualStyleBackColor = true;
            // 
            // radioButtonJugador
            // 
            radioButtonJugador.AutoSize = true;
            radioButtonJugador.Location = new Point(19, 49);
            radioButtonJugador.Name = "radioButtonJugador";
            radioButtonJugador.Size = new Size(167, 24);
            radioButtonJugador.TabIndex = 1;
            radioButtonJugador.TabStop = true;
            radioButtonJugador.Text = "Jugador de Posicion";
            radioButtonJugador.UseVisualStyleBackColor = true;
            // 
            // radioButtonPitcher
            // 
            radioButtonPitcher.AutoSize = true;
            radioButtonPitcher.Location = new Point(19, 23);
            radioButtonPitcher.Name = "radioButtonPitcher";
            radioButtonPitcher.Size = new Size(78, 24);
            radioButtonPitcher.TabIndex = 0;
            radioButtonPitcher.TabStop = true;
            radioButtonPitcher.Text = "Pitcher";
            radioButtonPitcher.UseVisualStyleBackColor = true;
            // 
            // buttonCapturar
            // 
            buttonCapturar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            buttonCapturar.Location = new Point(239, 676);
            buttonCapturar.Name = "buttonCapturar";
            buttonCapturar.Size = new Size(94, 29);
            buttonCapturar.TabIndex = 1;
            buttonCapturar.Text = "Capturar";
            buttonCapturar.UseVisualStyleBackColor = true;
            buttonCapturar.Click += buttonCapturar_Click;
            // 
            // buttonMostrar
            // 
            buttonMostrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            buttonMostrar.Location = new Point(360, 676);
            buttonMostrar.Name = "buttonMostrar";
            buttonMostrar.Size = new Size(94, 29);
            buttonMostrar.TabIndex = 2;
            buttonMostrar.Text = "Mostrar";
            buttonMostrar.UseVisualStyleBackColor = true;
            buttonMostrar.Click += buttonMostrar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            buttonSalir.Location = new Point(479, 676);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(94, 29);
            buttonSalir.TabIndex = 3;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // groupBoxDatos
            // 
            groupBoxDatos.Controls.Add(txtErrores);
            groupBoxDatos.Controls.Add(txtPonches);
            groupBoxDatos.Controls.Add(txtNombre);
            groupBoxDatos.Controls.Add(txtNumUniforme);
            groupBoxDatos.Controls.Add(numHits);
            groupBoxDatos.Controls.Add(label5);
            groupBoxDatos.Controls.Add(label4);
            groupBoxDatos.Controls.Add(label3);
            groupBoxDatos.Controls.Add(label2);
            groupBoxDatos.Controls.Add(label1);
            groupBoxDatos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxDatos.ForeColor = SystemColors.ButtonHighlight;
            groupBoxDatos.Location = new Point(428, 45);
            groupBoxDatos.Name = "groupBoxDatos";
            groupBoxDatos.Size = new Size(292, 239);
            groupBoxDatos.TabIndex = 4;
            groupBoxDatos.TabStop = false;
            groupBoxDatos.Text = "DATOS DEL JUGADOR";
            // 
            // txtErrores
            // 
            txtErrores.Location = new Point(125, 185);
            txtErrores.Name = "txtErrores";
            txtErrores.Size = new Size(150, 27);
            txtErrores.TabIndex = 9;
            // 
            // txtPonches
            // 
            txtPonches.Location = new Point(125, 109);
            txtPonches.Name = "txtPonches";
            txtPonches.Size = new Size(150, 27);
            txtPonches.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(125, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtNumUniforme
            // 
            txtNumUniforme.Location = new Point(125, 26);
            txtNumUniforme.Name = "txtNumUniforme";
            txtNumUniforme.Size = new Size(150, 27);
            txtNumUniforme.TabIndex = 6;
            // 
            // numHits
            // 
            numHits.Location = new Point(125, 147);
            numHits.Name = "numHits";
            numHits.Size = new Size(150, 27);
            numHits.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 189);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 4;
            label5.Text = "Errores";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 152);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 3;
            label4.Text = "Hits";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 116);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Ponches";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 75);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Num Uniforme";
            // 
            // txtMuestra
            // 
            txtMuestra.Location = new Point(87, 301);
            txtMuestra.Multiline = true;
            txtMuestra.Name = "txtMuestra";
            txtMuestra.Size = new Size(633, 346);
            txtMuestra.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(21, 696);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 6;
            label6.Text = "Ricardo FigFlo";
            // 
            // Jugador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(815, 737);
            Controls.Add(label6);
            Controls.Add(txtMuestra);
            Controls.Add(groupBoxDatos);
            Controls.Add(buttonSalir);
            Controls.Add(buttonMostrar);
            Controls.Add(buttonCapturar);
            Controls.Add(groupBoxPosicion);
            Name = "Jugador";
            Text = "Form1";
            groupBoxPosicion.ResumeLayout(false);
            groupBoxPosicion.PerformLayout();
            groupBoxDatos.ResumeLayout(false);
            groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxPosicion;
        private RadioButton radioButtonBateador;
        private RadioButton radioButtonJugador;
        private RadioButton radioButtonPitcher;
        private Button buttonCapturar;
        private Button buttonMostrar;
        private Button buttonSalir;
        private GroupBox groupBoxDatos;
        private TextBox txtErrores;
        private TextBox txtPonches;
        private TextBox txtNombre;
        private TextBox txtNumUniforme;
        private NumericUpDown numHits;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMuestra;
        private Label label6;
    }
}
