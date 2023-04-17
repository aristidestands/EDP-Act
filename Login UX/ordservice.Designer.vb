<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ordservice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnDineIn = New System.Windows.Forms.Button()
        Me.btnTakeOut = New System.Windows.Forms.Button()
        Me.btnDelivery = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDineIn
        '
        Me.btnDineIn.Location = New System.Drawing.Point(236, 460)
        Me.btnDineIn.Name = "btnDineIn"
        Me.btnDineIn.Size = New System.Drawing.Size(112, 34)
        Me.btnDineIn.TabIndex = 0
        Me.btnDineIn.Text = "Dine In"
        Me.btnDineIn.UseVisualStyleBackColor = True
        '
        'btnTakeOut
        '
        Me.btnTakeOut.Location = New System.Drawing.Point(388, 460)
        Me.btnTakeOut.Name = "btnTakeOut"
        Me.btnTakeOut.Size = New System.Drawing.Size(112, 34)
        Me.btnTakeOut.TabIndex = 1
        Me.btnTakeOut.Text = "Takeout"
        Me.btnTakeOut.UseVisualStyleBackColor = True
        '
        'btnDelivery
        '
        Me.btnDelivery.Location = New System.Drawing.Point(545, 460)
        Me.btnDelivery.Name = "btnDelivery"
        Me.btnDelivery.Size = New System.Drawing.Size(112, 34)
        Me.btnDelivery.TabIndex = 2
        Me.btnDelivery.Text = "Delivery"
        Me.btnDelivery.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Login_UX.My.Resources.Resources.black_coffee_759_petr_kratochvil_wikimedia_commons
        Me.PictureBox1.Location = New System.Drawing.Point(81, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(705, 312)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(372, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Services"
        '
        'service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(872, 535)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnDelivery)
        Me.Controls.Add(Me.btnTakeOut)
        Me.Controls.Add(Me.btnDineIn)
        Me.Name = "service"
        Me.Text = "service"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDineIn As Button
    Friend WithEvents btnTakeOut As Button
    Friend WithEvents btnDelivery As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
