<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class upload
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUploader = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(274, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DATASET VIEW"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(361, 360)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(76, 29)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Back"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnUploader
        '
        Me.btnUploader.Location = New System.Drawing.Point(229, 360)
        Me.btnUploader.Name = "btnUploader"
        Me.btnUploader.Size = New System.Drawing.Size(94, 29)
        Me.btnUploader.TabIndex = 2
        Me.btnUploader.Text = "Upload File"
        Me.btnUploader.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(61, 64)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 29
        Me.DataGridView3.Size = New System.Drawing.Size(565, 278)
        Me.DataGridView3.TabIndex = 4
        '
        'upload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(686, 450)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUploader)
        Me.Controls.Add(Me.Label1)
        Me.Name = "upload"
        Me.Text = "upload"
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnUploader As Button
    Friend WithEvents DataGridView3 As DataGridView
End Class
